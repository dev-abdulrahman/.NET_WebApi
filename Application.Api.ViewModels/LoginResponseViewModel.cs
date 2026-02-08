namespace Application.Api.ViewModels
{
    public class LoginResponseViewModel
    {
        public string? Name { get; set; }
        public string? Token { get; set; }
        public IEnumerable<EnrolledViewModel> Enrollments { get; set; }
    }
}
