using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDC.Domain.DTOs
{
    public class AnnotationDTO : DTO
    {
        public string? FileName { get; set; }
        public long? FileSize { get; set; }
        public bool? IsDocument { get; set; }
        public string? DocumentBody { get; set; }
        public string? MimeType { get; set; }
    }
}
