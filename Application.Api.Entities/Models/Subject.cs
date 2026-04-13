namespace Application.Api.Entities.Models
{
    public class Subject : BaseEntity
    {
        public int SubjectId { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; }= string.Empty;
        public string ImageName { get; set; }= string.Empty;
        public decimal Price { get; set; }
        public decimal? Discount { get; set; }

        // Foreign Keys
        public int BranchId { get; set; }

        // Navigation Properties
        public Branch Branch { get; set; } = null!;
        public ICollection<Chapter> Chapters { get; set; } = null!;
        public ICollection<Announcement> Announcements { get; set; } = null!;
    }
}
