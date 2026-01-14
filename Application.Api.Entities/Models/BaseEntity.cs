namespace Application.Api.Entities.Models
{
    public abstract class BaseEntity
    {
        public bool IsActive { get; set; }
        public DateTime CreatedDate { get; set; }
        public int CreatedBy { get; set; }
        public DateTime LastModifiedDate { get; set; }
        public int LastModifiedBy { get; set; }
    }
}
