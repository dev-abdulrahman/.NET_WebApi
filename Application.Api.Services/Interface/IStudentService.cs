using Application.Api.Entities.Models;

namespace Application.Api.Services.Interface
{
    public interface IStudentService
    {
        Task<ServiceResult<Student>> Register(Student student);
        Task<ServiceResult<Student>> GetStudentByUserId(string userId);
        Task<IEnumerable<Student>> GetAllStudents();
        void UpdateStudent(Student student);
    }
}
