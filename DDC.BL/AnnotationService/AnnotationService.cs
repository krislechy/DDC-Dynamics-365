using DDC.DAL;
using DDC.Domain.DTOs;
using Microsoft.Xrm.Sdk.Query;
using ProxyTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDC.BL
{
    public class AnnotationService : IAnnotationService
    {
        private readonly IAnnotationRepository annotationRepository;
        public AnnotationService(IAnnotationRepository annotationRepository)
        {
            this.annotationRepository = annotationRepository;
        }
        public async Task<IEnumerable<AnnotationDTO>> GetAnnotationsById(Guid Id, bool withContent = false)
        {
            var cs = new ColumnSet(
                    Annotation.annotationidName,
                    Annotation.filenameName,
                    Annotation.isdocumentName,
                    Annotation.mimetypeName);
            if (withContent)
                cs.Columns.Add(Annotation.documentbodyName);
            return await annotationRepository.RetrieveMultiple(new QueryExpression()
            {
                ColumnSet = cs,
                NoLock = true,
                Criteria = new FilterExpression()
                {
                    Conditions =
                    {
                        new ConditionExpression(Annotation.objectidName,ConditionOperator.Equal,Id),
                        new ConditionExpression(Annotation.isdocumentName,ConditionOperator.Equal,true)
                    }
                }
            });
        }

        public async Task<AnnotationDTO> GetAttachmentById(Guid Id)=>
            await annotationRepository.Retrieve(Id, new ColumnSet(Annotation.documentbodyName, Annotation.filenameName,Annotation.filesizeName));
    }
}
