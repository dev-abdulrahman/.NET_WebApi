using Application.Api.Entities.DbContext;
using Application.Api.Services.Interface;
using Microsoft.EntityFrameworkCore;

namespace Application.Api.Services.Implementation
{
    public class EnrollmentService : IEnrollmentService
    {
        private readonly AppDbContext _context;

        public EnrollmentService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<bool> IsStudentEnrolledInSubjectAsync(int studentId, int subjectId)
        {
            return await _context.Enrollment.AnyAsync(e => e.StudentId == studentId && e.BranchId == subjectId);
        }
    }
}
