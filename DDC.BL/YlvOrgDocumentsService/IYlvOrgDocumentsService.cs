using DDC.Domain.DTOs;

namespace DDC.BL
{
    public interface IYlvOrgDocumentsService
    {
        Task<IEnumerable<YlvOrgDocumentsDTO>> GetDocuments(DateTime? startDateTime);
    }
}