namespace Application.Api.Entities.Models
{
    public class LessonProgress
    {
        public int StudentId { get; set; }
        public int LessonId { get; set; }
        public double ProgressPercentage { get; set; }
        public bool IsCompleted { get; set; }
        public DateTime? CompletedDate { get; set; }

        // Navigation Properties 
        public Student Student { get; set; } = null!;
        public Lesson Lesson { get; set; } = null!;
    }
}
