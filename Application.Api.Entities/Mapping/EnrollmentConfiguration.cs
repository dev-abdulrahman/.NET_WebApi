using Application.Api.Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Application.Api.Entities.Mapping
{
    public class EnrollmentConfiguration : IEntityTypeConfiguration<Enrollment>
    {
        public void Configure(EntityTypeBuilder<Enrollment> builder)
        {
            builder.ToTable(nameof(Enrollment));
            builder.HasKey(x => x.EnrollmentId);

            builder.Property(x => x.EnrollmentDate).IsRequired();

            // Navigation Properties
            builder.HasOne(x => x.Student).WithMany(x => x.Enrollments).HasForeignKey(a => a.StudentId);
            builder.HasOne(x => x.Branch).WithMany(x => x.Enrollments).HasForeignKey(a => a.BranchId);
        }
    }
}
