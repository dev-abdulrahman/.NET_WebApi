using Application.Api.Entities.DbContext;
using Application.Api.Entities.Models;
using Application.Api.Services.Interface;
using Microsoft.EntityFrameworkCore;

namespace Application.Api.Services.Implementation
{
    public class LessonService : ILessonService
    {
        private readonly AppDbContext _context;

        public LessonService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<ServiceResult<IEnumerable<Lesson>>> GetLessonsByChapterId(int chapterId)
        {
            var lessons = await _context.Lesson.Where(l => l.ChapterId == chapterId).ToListAsync();
            if (!lessons.Any())
                return ServiceResult<IEnumerable<Lesson>>.Failure("No lessons found for the given chapter ID");
            
            return ServiceResult<IEnumerable<Lesson>>.Success(lessons);
        }
    }
}
