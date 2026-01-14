using Application.Api.Entities.Models;
using Application.Api.Services.Interface;
using Application.WebApi.ResponseFactory;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Application.WebApi.Controllers
{
    [ApiController]
    [Route("api/[Controller]")]
    [Authorize]
    public class LessonController : ControllerBase
    {
        private readonly ILessonService _lessonService;

        public LessonController(ILessonService lessonService)
        {
            _lessonService = lessonService;
        }

        [HttpGet("GetLessonsByChapterId/{chapterId}")]
        public async Task<IActionResult> GetLessonsByChapterId(int chapterId)
        {
            var result = await _lessonService.GetLessonsByChapterId(chapterId);
            if (!result.IsSuccess)
                return ApiResponseFactory.NotFound<Lesson>(result.Error);
            
            return ApiResponseFactory.Success(result.Data);
        }
    }
}
