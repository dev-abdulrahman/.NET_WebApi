namespace Application.Api.Entities.Models
{
    public class Enrollment : BaseEntity
    {
        public int EnrollmentId { get; set; }
        public DateTime EnrollmentDate { get; set; }

        // Foreign Keys
        public int StudentId { get; set; }
        public int BranchId { get; set; }

        // Navigation Properties
        public Student Student { get; set; } = null!; 
        public Branch Branch { get; set; } = null!;
    }
}
