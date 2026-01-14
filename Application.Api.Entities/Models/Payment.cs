namespace Application.Api.Entities.Models
{
    public class Payment : BaseEntity
    {
        public int PaymentId { get; set; }
        public decimal Amount { get; set; }
        public DateTime PaymentDate { get; set; }
        public string Status { get; set; } = string.Empty;
        public string? PaymentMethod { get; set; } = string.Empty;

        // Foreign Keys
        public int StudentId { get; set; }

        // Navigation Properties
        public Student Student { get; set; } = null!;
    }
}
