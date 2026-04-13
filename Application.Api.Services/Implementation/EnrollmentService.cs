using Application.Api.Entities.DbContext;
using Application.Api.Entities.Models;
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

        public async Task<List<Enrollment>> EnrollStudentsAsync(List<Enrollment> enrollments)
        {
            await _context.Enrollment.AddRangeAsync(enrollments);
            await _context.SaveChangesAsync();
            return enrollments;
        }

        public async Task<bool> IsStudentEnrolledInSubjectAsync(int studentId, int branchId)
        {
            return await _context.Enrollment.AnyAsync(e => e.StudentId == studentId && e.BranchId == branchId);
        }
    }
}
