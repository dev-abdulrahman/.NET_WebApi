using Application.Api.Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Application.Api.Entities.Mapping
{
    public class QuizResultConfiguration : IEntityTypeConfiguration<QuizResult>
    {
        public void Configure(EntityTypeBuilder<QuizResult> builder)
        {
            builder.ToTable(nameof(QuizResult));
            builder.HasKey(qr => qr.QuizResultId);

            builder.Property(qr => qr.Score).IsRequired(false);
            builder.Property(qr => qr.IsPassed).IsRequired(false);
            builder.Property(qr => qr.AttemptedDate).IsRequired(false);

            builder.ConfigureBaseEntity<QuizResult>();

            // Navigation Properties
            builder.HasOne(x => x.Student).WithMany(x => x.QuizResults).HasForeignKey(qr => qr.StudentId);
            builder.HasOne(x => x.Quiz).WithMany(x => x.QuizResults).HasForeignKey(qr => qr.QuizId);

        }
    }
}
