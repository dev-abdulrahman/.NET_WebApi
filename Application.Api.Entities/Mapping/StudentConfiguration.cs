using Application.Api.Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Application.Api.Entities.Mapping
{
    public class StudentConfiguration : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> builder)
        {
            builder.ToTable(nameof(Student));
            builder.HasKey(a => a.StudentId);

            builder.Property(a => a.FirstName).IsRequired().HasMaxLength(200);
            builder.Property(a => a.LastName).IsRequired().HasMaxLength(200);
            builder.Property(a => a.Gender).IsRequired();
            builder.Property(a => a.Email).IsRequired().HasMaxLength(200);
            builder.Property(a => a.PhoneNumber).IsRequired().HasMaxLength(20);
            builder.Property(x => x.CityId).IsRequired(false);
            builder.Property(x => x.CountryId).IsRequired(false);
            builder.Property(x => x.UserId).IsRequired();
            builder.Property(a => a.BoundDeviceId).IsRequired(false).HasMaxLength(200);
            builder.Property(a => a.CurrentSessionId).IsRequired(false).HasMaxLength(200);

            builder.ConfigureBaseEntity<Student>();

            // Navigation Properties
            builder.HasOne(x => x.City).WithMany(x => x.Students).HasForeignKey(a => a.CityId);
            builder.HasOne(x => x.Country).WithMany(x => x.Students).HasForeignKey(a => a.CountryId);
            builder.HasOne(x => x.User).WithOne(x => x.Student).HasForeignKey<Student>(a => a.UserId);

            builder.HasMany(s => s.Certificates).WithOne(c => c.Student).HasForeignKey(c => c.StudentId);
            builder.HasMany(s => s.Enrollments).WithOne(e => e.Student).HasForeignKey(e => e.StudentId);
            builder.HasMany(s => s.LessonProgresses) .WithOne(lp => lp.Student).HasForeignKey(lp => lp.StudentId);
            builder.HasMany(s => s.QuizResults).WithOne(qr => qr.Student).HasForeignKey(qr => qr.StudentId);
            builder.HasMany(s => s.Payments).WithOne(x => x.Student).HasForeignKey(a => a.StudentId);
        }
    }
}
