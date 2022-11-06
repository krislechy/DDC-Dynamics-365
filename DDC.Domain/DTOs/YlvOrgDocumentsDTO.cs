using Microsoft.Xrm.Sdk;
using ProxyTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDC.Domain.DTOs
{
    public class YlvOrgDocumentsDTO : DTO
    {
        public EntityReference? Account { get; set; }
        public EntityReference? @Object { get; set; }
        public EntityReference? Opportunity { get; set; }
        public ylv_objectpackettype? ObjectType{ get; set; }
        public string? Name { get; set; }
        public DateTime? UpdateDate { get; set; }
        public ylv_packettype? DocumentType { get; set; }
        public ylv_org_documents_ylv_document_status? Status { get; set; }
    }
}
