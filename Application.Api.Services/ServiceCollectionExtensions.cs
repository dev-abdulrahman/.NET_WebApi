using Application.Api.Services.Implementation;
using Application.Api.Services.Interface;
using Microsoft.Extensions.DependencyInjection;

namespace Application.Api.Services
{
    public static class ServiceCollectionExtensions
    {
        public static void AddServiceServices(this IServiceCollection services)
        {
            services.AddScoped<ITokenService, TokenService>();
            services.AddScoped<IStudentService, StudentService>();
            services.AddScoped<ISubjectService, SubjectService>();
            services.AddScoped<IChapterService, ChapterService>();
            services.AddScoped<ILessonService, LessonService>();
        }
    }
}
