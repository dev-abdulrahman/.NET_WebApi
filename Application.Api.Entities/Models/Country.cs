namespace Application.Api.Entities.Models
{
    public class Country : BaseEntity
    {
        public int CountryId { get; set; }
        public string Name { get; set; } = string.Empty;

        // Navigation Properties
        public ICollection<Student> Students { get; set; } = null!;
    }
}
