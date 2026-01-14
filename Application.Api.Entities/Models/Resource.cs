namespace Application.Api.Entities.Models
{
    public class Resource : BaseEntity
    {
        public int ResourceId { get; set; }
        public string Title { get; set; } = string.Empty;
        public string ResourceUrl { get; set; } = string.Empty;
        public ResourceType ResourceType { get; set; }

        // Foreign Keys
        public int LessonId { get; set; }

        // Navigation Properties
        public Lesson? Lesson { get; set; } = null;
    }
}
