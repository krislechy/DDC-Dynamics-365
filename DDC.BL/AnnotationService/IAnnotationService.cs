using DDC.Domain.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDC.BL
{
    public interface IAnnotationService
    {
        Task<IEnumerable<AnnotationDTO>> GetAnnotationsById(Guid Id, bool withContent = false);
        Task<AnnotationDTO> GetAttachmentById(Guid Id);
    }
}
