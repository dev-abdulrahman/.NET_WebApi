namespace Application.Api.Entities.Models
{
    public class Announcement : BaseEntity
    {
        public int AnnouncementId { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Message { get; set; } = string.Empty;
        public DateTime PostedDate { get; set; }

        // Foreign Keys
        public int SubjectId { get; set; }

        // Navigation Properties
        public Subject Subject { get; set; } = null!;
    }
}
