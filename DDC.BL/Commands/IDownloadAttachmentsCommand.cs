using DDC.Domain.DTOs;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDC.BL.Commands
{
    public struct IDownloadAttachmentsCommand : IRequest<DownloadAttachmentsCommandResult>
    {
        public string rootFolder { get; set; }
        public YlvOrgDocumentsDTO document { get; set; }
    }

    public struct DownloadAttachmentsCommandResult
    {
        public int TotalSuccess { get; set; }
        public int TotalFailed { get; set; }
    }
}
