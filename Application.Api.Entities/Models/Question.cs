namespace Application.Api.Entities.Models
{
    public class Question : BaseEntity
    {
        public int QuestionId { get; set; }
        public string Text { get; set; } = string.Empty;
        public string? ImageUrl { get; set; }
        public string? Explanation { get; set; }
        public QuestionType QuestionType { get; set; }
        public string? OptionA { get; set; } = string.Empty;
        public string? OptionB { get; set; } = string.Empty;
        public string? OptionC { get; set; } = string.Empty;
        public string? OptionD { get; set; } = string.Empty;
        public string Answer { get; set; } = string.Empty;

        // Foreign Keys
        public int QuizId { get; set; }

        // Navigation Properties
        public Quiz Quiz { get; set; } = null!;
    }
}
