using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace Application.WebApi.ResponseFactory
{
    public static class ApiResponseFactory
    {
        public static IActionResult Success<T>(T data, string? message = "Request successful", HttpStatusCode statusCode = HttpStatusCode.OK, string? input = null)
        {
            return new OkObjectResult(new ApiResponse<T>
            {
                Success = true,
                StatusCode = (int)statusCode,
                Input = input,
                Message = message,
                Data = data,
                Error = null
            });
        }

        public static ApiResponse<T> Error<T>(string? message, string? errorCode, string? details, HttpStatusCode statusCode, string? input = null)
        {
            return new ApiResponse<T>
            {
                Success = false,
                StatusCode = (int)statusCode,
                Input = input,
                Message = message,
                Data = default,
                Error = new ApiError
                {
                    Code = errorCode,
                    Details = details
                }
            };
        }

        public static IActionResult BadRequest<T>(string? message, string? errorDetails)
        {
            return new BadRequestObjectResult(Error<T>(
                message,
                "BAD_REQUEST",
                errorDetails,
                HttpStatusCode.BadRequest
                ));
        }

        public static IActionResult Unauthorized<T>(string? message, string? errorDetails)
        {
            return new UnauthorizedObjectResult(Error<T>(
                message,
                "Unauthorized",
                errorDetails,
                HttpStatusCode.Unauthorized
                ));
        }

        public static IActionResult NotFound<T>(string? message, string? errorDetails = null)
        {
            return new UnauthorizedObjectResult(Error<T>(
                message,
                "NOT_FOUND",
                errorDetails,
                HttpStatusCode.NotFound
                ));
        }

        public static IActionResult InternalServerError<T>(string? message, string? errorDetails = null)
        {
            return new ObjectResult(Error<T>(
                message,
                "InternalServerError",
                errorDetails,
                HttpStatusCode.InternalServerError
                ));
        }
    }
}
