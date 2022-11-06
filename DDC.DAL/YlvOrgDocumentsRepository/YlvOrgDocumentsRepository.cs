using DDC.Domain.DTOs;
using Microsoft.PowerPlatform.Dataverse.Client;
using Microsoft.Xrm.Sdk;
using ProxyTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDC.DAL
{
    public class YlvOrgDocumentsRepository : BaseRepository<YlvOrgDocumentsDTO>, IYlvOrgDocumentsRepository
    {
        public YlvOrgDocumentsRepository(IOrganizationServiceAsync service) : base(service)
        {

        }

        protected override string LogicalName => ProxyTypes.YlvOrgDocuments.EntityLogicalName;

        protected override Entity Convert(YlvOrgDocumentsDTO entity)
        {
            throw new NotImplementedException();
        }
        protected override YlvOrgDocumentsDTO Convert(Entity entity)
        {
            var e = entity.ToEntity<YlvOrgDocuments>();
            var dto = new YlvOrgDocumentsDTO()
            {
                ID = e.Id,
                Account= e.ylv_account,
                Object=e.ylv_objectid,
                Opportunity=e.ylv_opportunityid,
                ObjectType=e.ylv_docobjecttype,
                Name =e.ylv_name,
                UpdateDate=e.ylv_status_update_date,
                Status=e.ylv_document_status,
                DocumentType=e.ylv_doctype
            };
            return dto;
        }
    }
}
