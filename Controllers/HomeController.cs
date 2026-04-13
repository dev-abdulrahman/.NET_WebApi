using Application.Api.Entities.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authentication.Cookies;
using Application.Api.Services.Interface;

namespace Application.WebApi.Controllers
{
    [Authorize(AuthenticationSchemes = CookieAuthenticationDefaults.AuthenticationScheme)]
    public class HomeController : Controller
    {
        private readonly IStudentService _studentService;
        private readonly IEnrollmentService _enrollmentService;

        public HomeController(IStudentService studentService, IEnrollmentService enrollmentService)
        {
            _studentService = studentService;
            _enrollmentService = enrollmentService;
        }

        public async Task<IActionResult> Index()
        {
            var students = await _studentService.GetAllStudents();
            
            return View(students);
        }

        [HttpPost]
        public async Task<IActionResult> EnrollSelected(List<int> studentIds)
        {
            if (studentIds == null || !studentIds.Any())
            {
                TempData["Success"] = "No students selected.";
                return RedirectToAction("Index");
            }

            var enrollments = new List<Enrollment>();

            foreach (var studentId in studentIds)
            {
                enrollments.Add(new Enrollment
                {
                    EnrollmentDate = DateTime.UtcNow,
                    StudentId = studentId,
                    BranchId = 1,
                    IsActive = true,
                    CreatedDate = DateTime.UtcNow,
                    CreatedBy = 1,
                    LastModifiedDate = DateTime.UtcNow,
                    LastModifiedBy = 1,
                });
            }
            await _enrollmentService.EnrollStudentsAsync(enrollments);

            TempData["Success"] = $"Successfully enrolled {studentIds.Count} student(s).";

            return RedirectToAction("Index");
        }
    }
}
