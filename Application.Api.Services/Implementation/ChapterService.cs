using Application.Api.Entities.DbContext;
using Application.Api.Entities.Models;
using Application.Api.Services.Interface;
using Microsoft.EntityFrameworkCore;

namespace Application.Api.Services.Implementation
{
    public class ChapterService : IChapterService
    {
        private readonly AppDbContext _context;

        public ChapterService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<ServiceResult<IEnumerable<Chapter>>> GetChaptersBySubjectId(int subjectId)
        {

            var chapters = await _context.Chapter.Where(c => c.SubjectId == subjectId)
                                                 .Include(c => c.Lessons).ToListAsync();
            if (!chapters.Any())
                return ServiceResult<IEnumerable<Chapter>>.Failure("No chapters found for the given subject ID");
            
            return ServiceResult<IEnumerable<Chapter>>.Success(chapters);
        }
    }
}
