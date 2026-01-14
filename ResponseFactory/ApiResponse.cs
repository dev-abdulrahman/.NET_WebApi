namespace Application.WebApi.ResponseFactory
{
    public class ApiResponse<T>
    {
        public bool Success { get; set; }
        public string? Message { get; set; }
        public string? Input { get; set; }
        public T? Data { get; set; }
        public int StatusCode { get; set; }
        public ApiError? Error { get; set; }
    }
}
