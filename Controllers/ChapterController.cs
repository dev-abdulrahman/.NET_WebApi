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
    public class ChapterController : ControllerBase
    {
        private readonly IChapterService _chapterService;

        public ChapterController(IChapterService chapterService)
        {
            _chapterService = chapterService;
        }

        [HttpGet("GetChaptersBySubjectId/{subjectId}")]
        public async Task<IActionResult> GetChapterBySubjectId(int subjectId)
        {
            var chaptersResult = await _chapterService.GetChaptersBySubjectId(subjectId);
            if (!chaptersResult.IsSuccess)
                return ApiResponseFactory.NotFound<Chapter>(chaptersResult.Error);
            
            return ApiResponseFactory.Success(chaptersResult.Data);
        }
    }
}
