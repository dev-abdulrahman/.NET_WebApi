using Application.Api.Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Application.Api.Entities.Mapping
{
    public class QuestionConfiguration : IEntityTypeConfiguration<Question>
    {
        public void Configure(EntityTypeBuilder<Question> builder)
        {
            builder.ToTable(nameof(Question));
            builder.HasKey(q => q.QuestionId);

            builder.Property(q => q.Text).IsRequired().HasMaxLength(2000);
            builder.Property(q => q.ImageUrl).HasMaxLength(500);
            builder.Property(q => q.Explanation).HasMaxLength(4000);
            builder.Property(q => q.QuestionType).IsRequired();
            builder.Property(q => q.OptionA).IsRequired(false).HasMaxLength(500);
            builder.Property(q => q.OptionB).IsRequired(false).HasMaxLength(500);
            builder.Property(q => q.OptionC).IsRequired(false).HasMaxLength(500);
            builder.Property(q => q.OptionD).IsRequired(false).HasMaxLength(500);
            builder.Property(q => q.Answer).IsRequired().HasMaxLength(1000);

            builder.ConfigureBaseEntity<Question>();

            // Navigation Properties
            builder.HasOne(x => x.Quiz).WithMany(x => x.Questions).HasForeignKey(q => q.QuizId);

        }
    }
}
