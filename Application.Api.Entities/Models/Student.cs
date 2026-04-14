namespace Application.Api.Entities.Models
{
    public class Student : BaseEntity
    {
        public int StudentId { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public Gender Gender { get; set; }
        public string Email { get; set; } = string.Empty;
        public string PhoneNumber { get; set; } = string.Empty;
        public string BoundDeviceId { get; set; } = string.Empty;
        public string CurrentSessionId { get; set; } = string.Empty;

        // Foreign Keys
        public int? CityId { get; set; }
        public int? CountryId { get; set; }
        public string UserId { get; set; } = null!;

        // Navigation Properties
        public City? City { get; set; }
        public Country? Country { get; set; }
        public User User { get; set; } = null!;
        public ICollection<Certificate> Certificates { get; set; } = null!;
        public ICollection<Enrollment> Enrollments { get; set; } = null!;
        public ICollection<LessonProgress> LessonProgresses { get; set; } = new List<LessonProgress>();
        public ICollection<QuizResult> QuizResults { get; set; } = new List<QuizResult>();
        public ICollection<Payment> Payments { get; set; } = new List<Payment>();
    }
}
