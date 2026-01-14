namespace Application.Api.Entities.Models
{
    public class Branch : BaseEntity
    {
        public int BranchId { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; }= string.Empty;

        // Navigation Properties
        public ICollection<Subject> Subjects { get; set; } = null!;
        public ICollection<Enrollment> Enrollments { get; set; } = null!;
        public ICollection<Student> Students { get; set; } = null!;
    }
}
