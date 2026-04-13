using Application.Api.Entities.DbContext;
using Application.Api.Entities.Models;
using Application.Api.Services.Interface;
using Microsoft.EntityFrameworkCore;

namespace Application.Api.Services.Implementation
{
    public class StudentService : IStudentService
    {
        private readonly AppDbContext _context;

        public StudentService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<ServiceResult<Student>> Register(Student student)
        {
            try
            {
                await _context.AddAsync(student);
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                return ServiceResult<Student>.Failure($"An error occurred while registering the student: {ex.Message}");
            }

            return ServiceResult<Student>.Success(student);
        }

        public async Task<ServiceResult<Student>> GetStudentByUserId(string userId)
        {
            try
            {
                var student = await _context.Student.Where(x => x.IsActive && x.UserId == userId)
                                                    .Include(x => x.Enrollments).FirstAsync();
                if (student != null) 
                {
                    return ServiceResult<Student>.Success(student);
                }
            }
            catch (Exception ex)
            {
                return ServiceResult<Student>.Failure($"An error occurred while registering the student: {ex.Message}");
            }

            return ServiceResult<Student>.Failure($"No student found with the userId: {userId}");
        }

        public async Task<IEnumerable<Student>> GetAllStudents()
        {
            return await _context.Student.Where(x => x.IsActive)
                                         .Include(x => x.Enrollments).ToListAsync();
        }
    }
}
