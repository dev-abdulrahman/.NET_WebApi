using Application.Api.Entities.DbContext;
using Application.Api.Entities.Models;
using Application.Api.Services.Interface;
using Microsoft.EntityFrameworkCore;

namespace Application.Api.Services.Implementation
{
    public class SubjectService : ISubjectService
    {
        private readonly AppDbContext _context;

        public SubjectService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<ServiceResult<IEnumerable<Subject>>> GetAllSubjects()
        {
            var subjects = await _context.Subject.AsNoTracking().ToListAsync();

            if (!subjects.Any())
                return ServiceResult<IEnumerable<Subject>>.Failure("No subjects found");

            return ServiceResult<IEnumerable<Subject>>.Success(subjects);
        }
    }
}
