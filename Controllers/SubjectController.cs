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
    public class SubjectController : ControllerBase
    {
        private readonly ISubjectService _subjectService;
        public SubjectController(ISubjectService subjectService)
        {
            _subjectService = subjectService;
        }

        [HttpGet("GetAllSubjects")]
        public async Task<IActionResult> GetAllSubjects()
        {
            var result = await _subjectService.GetAllSubjects();
            if (!result.IsSuccess)
                return ApiResponseFactory.NotFound<Subject>(result.Error);
            
            return ApiResponseFactory.Success(result.Data);
        }
    }
}
