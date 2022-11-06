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
    public class AnnotationRepository : BaseRepository<AnnotationDTO>, IAnnotationRepository
    {
        public AnnotationRepository(IOrganizationServiceAsync service) : base(service)
        {
        }

        protected override string LogicalName => ProxyTypes.Annotation.EntityLogicalName;

        protected override Entity Convert(AnnotationDTO entity)
        {
            throw new NotImplementedException();
        }

        protected override AnnotationDTO Convert(Entity entity)
        {
            var e = entity.ToEntity<Annotation>();
            return new AnnotationDTO()
            {
                ID = e.Id,
                DocumentBody = e.DocumentBody,
                FileName = e.FileName,
                FileSize = e.FileSize,
                IsDocument = e.IsDocument,
                MimeType = e.MimeType
            };
        }
    }
}
