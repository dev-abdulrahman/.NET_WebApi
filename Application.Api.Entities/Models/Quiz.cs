namespace Application.Api.Entities.Models
{
    public class Quiz : BaseEntity
    {
        public int QuizId { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public double? Duration { get; set; }

        // Foreign Keys
        public int ChapterId { get; set; }

        // Navigation Properties
        public ICollection<Question> Questions { get; set; } = new List<Question>();
        public ICollection<QuizResult> QuizResults { get; set; } = new List<QuizResult>();
    }
}
