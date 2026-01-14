namespace Application.Api.Entities.Models
{
    public class City : BaseEntity
    {
        public int CityId { get; set; }
        public string Name { get; set; } = string.Empty;

        // Navigation Properties
        public ICollection<Student> Students { get; set; } = null!;
    }
}
