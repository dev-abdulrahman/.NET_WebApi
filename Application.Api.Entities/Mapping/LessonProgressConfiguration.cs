using Application.Api.Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Application.Api.Entities.Mapping
{
    public class LessonProgressConfiguration : IEntityTypeConfiguration<LessonProgress>
    {
        public void Configure(EntityTypeBuilder<LessonProgress> builder)
        {
            builder.ToTable(nameof(LessonProgress));
            builder.HasKey(x => new { x.StudentId, x.LessonId });

            builder.Property(a => a.StudentId).IsRequired();
            builder.Property(a => a.LessonId).IsRequired();
            builder.Property(a => a.ProgressPercentage).IsRequired().HasPrecision(5, 2);
            builder.Property(a => a.IsCompleted).IsRequired();
            builder.Property(a => a.CompletedDate).IsRequired(false);

            builder.HasOne(x => x.Student).WithMany(x => x.LessonProgresses).HasForeignKey(x => x.StudentId);
            builder.HasOne(x => x.Lesson).WithMany(x => x.LessonProgresses).HasForeignKey(x => x.LessonId);
        }
    }
}
