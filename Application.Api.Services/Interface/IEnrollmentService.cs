namespace Application.Api.Services.Interface
{
    public interface IEnrollmentService
    {
        Task<bool> IsStudentEnrolledInSubjectAsync(int studentId, int subjectId);
    }
}
