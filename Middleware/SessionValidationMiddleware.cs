using Application.Api.Entities.DbContext;
using Microsoft.EntityFrameworkCore;

namespace Application.WebApi.Middleware
{
    public class SessionValidationMiddleware
    {
        private readonly RequestDelegate _next;

        public SessionValidationMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext context, AppDbContext dbContext)
        {
            var sessionIdFromToken = context.User.Claims
                .FirstOrDefault(c => c.Type == "SessionId")?.Value;

            var userId = context.User.Claims.FirstOrDefault(c => c.Type == "UserId")?.Value;

            if (userId != null)
            {
                var currentDbSessionId = await dbContext.Student
                    .Where(u => u.UserId == userId)
                    .Select(u => u.CurrentSessionId)
                    .FirstOrDefaultAsync();

                if (sessionIdFromToken != currentDbSessionId)
                {
                    context.Response.StatusCode = StatusCodes.Status401Unauthorized;
                    await context.Response.WriteAsync("Account logged in on another device.");
                    return;
                }
            }

            await _next(context);
        }
    }
}
