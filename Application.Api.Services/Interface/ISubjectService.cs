using Application.Api.Entities.Models;

namespace Application.Api.Services.Interface
{
    public interface ISubjectService
    {
        Task<ServiceResult<IEnumerable<Subject>>> GetAllSubjects();
    }
}
