namespace Application.Api.Entities.Models
{
    public class QuizResult : BaseEntity
    {
        public int QuizResultId { get; set; }
        public double? Score { get; set; }
        public bool? IsPassed { get; set; }
        public DateTime? AttemptedDate { get; set; }

        // Foreign Keys
        public int StudentId { get; set; }
        public int QuizId { get; set; }

        // Navigation Properties
        public Student Student { get; set; } = null!;
        public Quiz Quiz { get; set; } = null!;
    }
}
