using Application.Api.Entities.Models;

namespace Application.Api.Services.Interface
{
    public interface IChapterService
    {
        Task<ServiceResult<IEnumerable<Chapter>>> GetChaptersBySubjectId(int subjectId);
    }
}
