using Application.Api.Entities.Models;

namespace Application.Api.Services.Interface
{
    public interface ILessonService
    {
        Task<ServiceResult<IEnumerable<Lesson>>> GetLessonsByChapterId(int chapterId);
    }
}
