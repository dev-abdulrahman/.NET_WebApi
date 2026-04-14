using Application.Api.Entities.Models;
using Application.Api.Services.Interface;
using Application.Api.ViewModels;
using Application.WebApi.ResponseFactory;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Text;

namespace Application.WebApi.Controllers
{
    [ApiController]
    [Route("api/[Controller]")]
    public class AuthController : ControllerBase
    {
        private readonly UserManager<User> _userManager;
        private readonly ITokenService _tokenService;
        private readonly IStudentService _studentService;

        public AuthController(
            UserManager<User> userManager,
            ITokenService tokenService,
            IStudentService studentService)
        {
            _userManager = userManager;
            _tokenService = tokenService;
            _studentService = studentService;
        }

        [HttpPost("register")]
        public async Task<IActionResult> Register([FromBody] RegisterViewModel registerViewModel)
        {
            if (await _userManager.FindByEmailAsync(registerViewModel.Email) != null)
                return ApiResponseFactory.BadRequest<RegisterViewModel>("Email is already registered", "Email is already registered");

            var user = new User
            {
                UserName = registerViewModel.Email,
                Email = registerViewModel.Email
            };

            Student student;
            try
            {
                var result = await _userManager.CreateAsync(user, registerViewModel.Password);
                
                if (!result.Succeeded)
                {
                    var errorDetails = new StringBuilder();

                    foreach (var error in result.Errors)
                    {
                        errorDetails.AppendLine(error?.Description.ToString());
                    }
                    return ApiResponseFactory.BadRequest<RegisterViewModel>(errorDetails.ToString(), "User Create Error");
                }

                student = new Student
                {
                    FirstName = registerViewModel.FirstName,
                    LastName = registerViewModel.LastName,
                    PhoneNumber = registerViewModel.PhoneNumber,
                    UserId = user.Id,
                    Gender = (Gender)registerViewModel.Gender,
                    Email = registerViewModel.Email,
                    IsActive = true
                };

                var studentResult = await _studentService.Register(student);
                if (!studentResult.IsSuccess)
                    return ApiResponseFactory.BadRequest<RegisterViewModel>("User Register Error", studentResult.Error);
            }
            catch (Exception ex)
            {
                return ApiResponseFactory.BadRequest<RegisterViewModel>("Internal Service Error", ex.Message);
            }

            return ApiResponseFactory.Success(new
            {
                student.LastName,
                student.PhoneNumber,
                student.Gender,
                student.Email
            },
            "Registered successfully");
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] LoginViewModel model)
        {
            var user = await _userManager.FindByEmailAsync(model.Email);
            if (user == null)
                return ApiResponseFactory.Unauthorized<LoginViewModel>("Invalid Email or Password", "");

            var valid = await _userManager.CheckPasswordAsync(user, model.Password);
            if (!valid)
                return ApiResponseFactory.BadRequest<LoginViewModel>("Invalid Email or Password", "");

            var result = await _studentService.GetStudentByUserId(user.Id);
            if (!result.IsSuccess)
            {
                return ApiResponseFactory.NotFound<LoginViewModel>("Student not found with the provided credentials.", result.Error);
            }

            string sessionId = Guid.NewGuid().ToString();
            var student = result.Data;

            if (string.IsNullOrEmpty(result.Data.BoundDeviceId))
            {
                student.BoundDeviceId = model.DeviceId;
            }
            else if (result.Data.BoundDeviceId.ToLower() != model.DeviceId.ToLower())
            {
                return ApiResponseFactory.Unauthorized<LoginViewModel>("This account is locked to another device.", "");
            }

            student.CurrentSessionId = sessionId;
            _studentService.UpdateStudent(student);

            var roles = await _userManager.GetRolesAsync(user);
            var token = _tokenService.GenerateToken(user, roles, sessionId);

            var login = new LoginResponseViewModel
            {
                Token = token,
                Name = result.Data?.FirstName,
                Enrollments = result.Data?.Enrollments?.Select(e => new EnrolledViewModel
                {
                    BranchId = e.BranchId,
                    IsEnrolled = true
                }).ToList() ?? new List<EnrolledViewModel>()
            };
            return ApiResponseFactory.Success(login);
        }
    }
}
