using Application.Api.Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Application.Api.Entities.Mapping
{
    public class ResourceConfiguration : IEntityTypeConfiguration<Resource>
    {
        public void Configure(EntityTypeBuilder<Resource> builder)
        {
            builder.ToTable(nameof(Resource));
            builder.HasKey(a => a.ResourceId);

            builder.Property(a => a.Title).IsRequired().HasMaxLength(200);
            builder.Property(a => a.ResourceUrl).IsRequired().HasMaxLength(1000);
            builder.Property(a => a.ResourceType).IsRequired();

            builder.ConfigureBaseEntity<Resource>();

            // Navigation Properties
            builder.HasOne(x => x.Lesson).WithMany(x => x.Resources).HasForeignKey(a => a.LessonId);
        }
    }
}
