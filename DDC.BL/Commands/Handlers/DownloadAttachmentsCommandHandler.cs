using DDC.BL.Services;
using DDC.Domain.DTOs;
using MediatR;
using Microsoft.Extensions.Configuration;
using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDC.BL.Commands.Handlers
{
    public sealed class DownloadAttachmentsCommandHandler : IRequestHandler<IDownloadAttachmentsCommand, DownloadAttachmentsCommandResult>
    {
        private readonly IConfiguration configuration;
        private readonly IYlvOrgDocumentsService ylvOrgDocumentsService;
        private readonly IAnnotationService annotationService;
        private readonly ILogger logger;
        public DownloadAttachmentsCommandHandler(
            IConfiguration configuration,
            IYlvOrgDocumentsService ylvOrgDocumentsService,
            IAnnotationService annotationService,
            ILogger logger)
        {
            this.configuration = configuration;
            this.ylvOrgDocumentsService = ylvOrgDocumentsService;
            this.annotationService = annotationService;
            this.logger = logger;
        }
        public async Task<DownloadAttachmentsCommandResult> Handle(IDownloadAttachmentsCommand request, CancellationToken cancellationToken)
        {
            var document = request.document;
            var rootFolder=request.rootFolder;

            logger.Info($"Current: {document.ID}");

            var folder = new FolderCreator(rootFolder,
                GetValue(document.Account?.Name),
                GetValue(document.Object?.Name),
                //GetValue(document.DocumentType),
                document.DocumentType == ProxyTypes.ylv_packettype.Аккредитация_заказов ? GetValue(document.DocumentType) : GetValue(document.ObjectType),
                GetValue(document.Name),
                $"{DateToString(document.UpdateDate)} {GetValue(document.Status)}");

            var annotations = await annotationService.GetAnnotationsById(document.ID);
            var totalFiles = annotations.Count();
            int totalDownloadedFiles = 0;
            int totalFailedDownloaded = 0;
            await Parallel.ForEachAsync(annotations, new ParallelOptions { MaxDegreeOfParallelism = 3 }, async (annotation, cancelAnnotation) =>
            {
                var attachment = await annotationService.GetAttachmentById(annotation.ID);
                if (attachment == null || attachment.FileName == null || attachment.DocumentBody == null) return;
                folder.CreateFolderChain();
                logger.Info($"File {annotation.ID} of document {document.ID} ({((double)attachment.FileSize * 0.000001).ToString("N4")} MB) - downloaded!");
                var fileName = attachment.FileName;
                if (document.ObjectType == ProxyTypes.ylv_objectpackettype.Договор_с_оператором)
                    fileName = $"{(document.Opportunity == null ? "Без договора" : document.Opportunity?.Name)}_{attachment.FileName}";
                var fullyPathFile = folder.FullPath + "\\" + folder.UnscapeFromInvalidFileName(fileName);

                WriteAttachment(fullyPathFile,attachment,ref totalDownloadedFiles,ref totalFailedDownloaded);

                logger.Info($"File {annotation.ID} of document {document.ID} was saved!");
            });
            if (listPending.Count() > 0)
            {
                foreach (var taskPending in listPending)
                {
                    await Task.Delay(TimeSpan.FromSeconds(60));
                    taskPending.Start();
                    var resultPending = await taskPending;
                    if (resultPending.Result)
                    {
                        totalFailedDownloaded--;
                        totalDownloadedFiles++;
                        logger.Warn($"Pending success! documentID: {document.ID},File {resultPending.ID}");
                    }
                    else
                    {
                        logger.Error($"Pending failed! documentID: {document.ID},File {resultPending.ID}");
                    }
                }
            }
            return new DownloadAttachmentsCommandResult { TotalSuccess = totalDownloadedFiles,TotalFailed = totalFailedDownloaded };
        }
        private List<Task<(Guid ID,bool Result)>> listPending = new();
        private void PendingWriteAttachment(string fullyPathFile, AnnotationDTO annotationDTO)
        {
            if (annotationDTO?.DocumentBody == null) return;
            listPending.Add(
                new Task<(Guid ID, bool Result)>(() =>
                {
                    try
                    {
                        WriteFile(fullyPathFile, annotationDTO.DocumentBody);
                    }
                    catch { return (annotationDTO.ID, false); }
                    return (annotationDTO.ID, true);
                }));
        }
        private void WriteAttachment(string fullyPathFile,AnnotationDTO annotationDTO,ref int totalDownloadedFiles,ref int totalFailedDownloaded)
        {
            try
            {
                if (annotationDTO?.DocumentBody == null) return;
                WriteFile(fullyPathFile, annotationDTO.DocumentBody);
                Interlocked.Increment(ref totalDownloadedFiles);
            }
            catch (Exception ex)
            {
                logger.Error($"File ID: {annotationDTO.ID}, {ex.Message}");
                Interlocked.Increment(ref totalFailedDownloaded);
                PendingWriteAttachment(fullyPathFile, annotationDTO);
                logger.Warn($"File added to pending list: {annotationDTO.ID}");
            }
        }
        private void WriteFile(string fullyPathFile,string attachmentBody)
        {
            using (var fs = new FileStream(fullyPathFile, FileMode.OpenOrCreate, FileAccess.Write))
            {
                fs.Write(Convert.FromBase64String(attachmentBody));
                fs.Close();
            }
        }
        private string GetValue(dynamic? value)
        {
            if (value != null)
            {
                string str = value.ToString();
                if (str.Contains("_"))
                    str = str.Replace("_", " ");
                if (str.Length > 200)
                    str = str.Substring(0, 200) + "...";
                return str;
            }
            return "Без названия";
        }
        private string DateToString(DateTime? dt)
        {
            dt = dt.Value.ToLocalTime();
            return dt == null ? "__.__.__" :
             $"{dt.Value.Day}.{dt.Value.Month}.{dt.Value.Year}";
        }
    }
}
