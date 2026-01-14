namespace Application.Api.Entities.Models
{
    public class Certificate : BaseEntity
    {
        public int CertificateId { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public DateTime IssuedDate { get; set; }

        // Foreign Keys
        public int StudentId { get; set; }

        // Navigation Properties
        public Student Student { get; set; } = null!;
    }
}
