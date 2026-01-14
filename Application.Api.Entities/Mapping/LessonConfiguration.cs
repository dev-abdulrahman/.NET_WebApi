using Application.Api.Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Application.Api.Entities.Mapping
{
    public class LessonConfiguration : IEntityTypeConfiguration<Lesson>
    {
        public void Configure(EntityTypeBuilder<Lesson> builder)
        {
            builder.ToTable(nameof(Lesson));
            builder.HasKey(a => a.LessonId);

            builder.Property(a => a.Title).IsRequired().HasMaxLength(200);
            builder.Property(a => a.Description).IsRequired().HasMaxLength(2000);
            builder.Property(a => a.LessonType).IsRequired().HasMaxLength(2000);

            builder.ConfigureBaseEntity<Lesson>();

            // Relationships
            builder.HasOne(x => x.Chapter).WithMany(x => x.Lessons).HasForeignKey(x => x.ChapterId);
        }
    }
}
