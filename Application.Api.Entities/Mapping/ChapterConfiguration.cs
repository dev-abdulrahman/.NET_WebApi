using Application.Api.Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Application.Api.Entities.Mapping
{
    public class ChapterConfiguration : IEntityTypeConfiguration<Chapter>
    {
        public void Configure(EntityTypeBuilder<Chapter> builder)
        {
            builder.ToTable("Chapter");
            builder.HasKey(a => a.ChapterId);

            builder.Property(a => a.Order).IsRequired();
            builder.Property(a => a.Title).IsRequired().HasMaxLength(200);
            builder.Property(a => a.Content).IsRequired();

            builder.ConfigureBaseEntity<Chapter>();

            // Foreign Keys
            builder.Property(x => x.SubjectId).IsRequired();

            // Navigation Properties
            builder.HasOne<Subject>().WithMany(x => x.Chapters).HasForeignKey(a => a.SubjectId);
            builder.HasMany<Lesson>().WithOne(x => x.Chapter).HasForeignKey(x => x.ChapterId);

        }
    }
}
