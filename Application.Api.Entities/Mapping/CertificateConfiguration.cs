using Application.Api.Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Application.Api.Entities.Mapping
{
    public class CertificateConfiguration : IEntityTypeConfiguration<Certificate>
    {
        public void Configure(EntityTypeBuilder<Certificate> builder)
        {
            builder.ToTable("Certificate");
            builder.HasKey(a => a.CertificateId);

            builder.Property(a => a.Title).IsRequired().HasMaxLength(200);
            builder.Property(a => a.Description).IsRequired().HasMaxLength(2000);
            builder.Property(a => a.IssuedDate).IsRequired();

            // Foreign Keys
            builder.Property(x => x.StudentId).IsRequired();

            // Navigation Properties
            builder.HasOne<Student>().WithMany(x => x.Certificates).HasForeignKey(a => a.StudentId);

        }
    }
}
