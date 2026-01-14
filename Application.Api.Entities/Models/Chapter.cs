namespace Application.Api.Entities.Models
{
    public class Chapter : BaseEntity
    {
        public int ChapterId { get; set; }
        public int Order { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Content { get; set; } = string.Empty;

        // Foreign Keys
        public int SubjectId { get; set; }

        // Navigation Properties
        public Subject Subject { get; set; } = null!;
        public ICollection<Lesson> Lessons { get; set; } = new List<Lesson>();
    }
}
