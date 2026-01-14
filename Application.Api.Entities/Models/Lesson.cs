using System.Resources;

namespace Application.Api.Entities.Models
{
    public class Lesson : BaseEntity
    {
        public int LessonId { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public LessonType LessonType { get; set; }

        // Foreign Keys
        public int ChapterId { get; set; }

        // Navigation Properties
        public Chapter Chapter { get; set; }
        public ICollection<LessonProgress> LessonProgresses { get; set; } = new List<LessonProgress>();
        public ICollection<Resource> Resources { get; set; } = new List<Resource>();
    }
}
