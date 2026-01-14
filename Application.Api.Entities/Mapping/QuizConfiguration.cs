using Application.Api.Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Application.Api.Entities.Mapping
{
    public class QuizConfiguration : IEntityTypeConfiguration<Quiz>
    {
        public void Configure(EntityTypeBuilder<Quiz> builder)
        {
            builder.ToTable(nameof(Quiz));
            builder.HasKey(a => a.QuizId);

            builder.Property(a => a.Title).IsRequired().HasMaxLength(500);
            builder.Property(a => a.Description).IsRequired().HasMaxLength(2000);
            builder.Property(a => a.Duration).IsRequired(false);

            builder.ConfigureBaseEntity<Quiz>();

            // Foreign Keys
            builder.Property(x => x.ChapterId).IsRequired();

            // Navigation Properties
            builder.HasMany(x => x.Questions).WithOne(x => x.Quiz).HasForeignKey(x => x.QuizId);

        }
    }
}
