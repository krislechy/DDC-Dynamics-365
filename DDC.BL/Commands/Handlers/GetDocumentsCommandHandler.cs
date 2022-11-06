using DDC.BL.Services;
using MediatR;
using Microsoft.Extensions.Configuration;
using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDC.BL.Commands
{

    public sealed class ResultAction
    {
        public ResultAction(bool isSuccess, string? message)
        {
            IsSuccess = isSuccess;
            Message = message;
        }

        public bool IsSuccess { get; set; }
        public string? Message { get; set; }
    }
    public sealed class GetDocumentsCommandHandler : IRequestHandler<IGetDocumentsCommand, ResultAction>
    {
        private readonly IMediator mediator;
        private readonly IConfiguration configuration;
        private readonly IYlvOrgDocumentsService ylvOrgDocumentsService;
        private readonly IAnnotationService annotationService;
        private readonly ILogger logger;
        public GetDocumentsCommandHandler(
            IMediator mediator,
            IConfiguration configuration,
            IYlvOrgDocumentsService ylvOrgDocumentsService,
            IAnnotationService annotationService,
            ILogger logger)
        {
            this.mediator = mediator;
            this.configuration = configuration;
            this.ylvOrgDocumentsService = ylvOrgDocumentsService;
            this.annotationService = annotationService;
            this.logger = logger;
        }
        public async Task<ResultAction> Handle(IGetDocumentsCommand request, CancellationToken cancellationToken)
        {
            try
            {
                DateTime? geDt = null;
                if (request.Args == null || request.Args.Length == 0)
                    logger.Warn("Params is empty");
                else
                {
                    var isExistDate = request.Args.Any(x => x.StartsWith("--ge", StringComparison.OrdinalIgnoreCase)) && request.Args.Length == 2;
                    if (!isExistDate) { logger.Error("Date not existing in params"); return new ResultAction(false, $"Не хватает значения для параметра --ge."); };
                    var isDate = DateTime.TryParse(request.Args[1], out DateTime _geDt);
                    if (!isDate) { logger.Error("Cannot parse current param to DateTime"); return new ResultAction(false, $"Невозможно преобразовать \"{request.Args[1]}\" в тип \"DateTime\""); };
                    geDt = _geDt;
                    logger.Info($"--ge:{geDt}");
                }
                var rootFolder = configuration.GetSection("Folder").GetValue<string>("RootFolder");
                var documents = await ylvOrgDocumentsService.GetDocuments(geDt);
                logger.Info($"Total Received documents: {documents.Count()}");
                var totalCountDocuments = documents.Count();
                var current = 0;
                var totalDownloadedFiles = 0;
                var totalFailedDownloaded = 0;
                await Parallel.ForEachAsync(documents, new ParallelOptions { MaxDegreeOfParallelism = 4 }, async (document, cancelDocument) =>
                    {
                        var command= new IDownloadAttachmentsCommand(){
                            document = document,
                            rootFolder=rootFolder
                        };
                        var result=await mediator.Send(command);
                        Interlocked.Add(ref totalDownloadedFiles, result.TotalSuccess);
                        Interlocked.Add(ref totalFailedDownloaded, result.TotalFailed);
                        current++;
                        logger.Info($"Document Completed: {document.ID} ({current}/{totalCountDocuments}), " +
                            $"STATUS(success|failed):{totalDownloadedFiles}|{totalFailedDownloaded})");
                    });
                logger.Info($"{nameof(IGetDocumentsCommand)} successfully completed (success:{totalDownloadedFiles}|failed:{totalFailedDownloaded})!");
                return new ResultAction(true, $"Успешно выгружено файлов: {totalDownloadedFiles},\nНе удалось выгрузить: {totalFailedDownloaded}\nУдаленная корневая директория выгрузки: {rootFolder}");
            }
            catch (Exception ex)
            {
                logger.Fatal(ex);
                return new ResultAction(false, ex.Message);
            }
        }
    }
}
