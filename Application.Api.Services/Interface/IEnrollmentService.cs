using Application.Api.Entities.Models;

namespace Application.Api.Services.Interface
{
    public interface IEnrollmentService
    {
        Task<List<Enrollment>> EnrollStudentsAsync(List<Enrollment> enrollments);
        Task<bool> IsStudentEnrolledInSubjectAsync(int studentId, int subjectId);
    }
}
