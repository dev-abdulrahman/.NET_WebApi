using Application.Api.Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Application.Api.Entities.Mapping
{
    public class SubjectConfiguration : IEntityTypeConfiguration<Subject>
    {
        public void Configure(EntityTypeBuilder<Subject> builder)
        {
            builder.ToTable(nameof(Subject));
            builder.HasKey(a => a.SubjectId);

            builder.Property(a => a.Name).IsRequired().HasMaxLength(500);
            builder.Property(a => a.Description).IsRequired().HasMaxLength(2000);
            builder.Property(a => a.ImageName).IsRequired(false).HasMaxLength(100);
            
            builder.ConfigureBaseEntity<Subject>();
            
            // Navigation Properties
            builder.HasOne<Branch>(x => x.Branch).WithMany(x => x.Subjects).HasForeignKey(x => x.BranchId);

            builder.HasMany<Chapter>(x => x.Chapters).WithOne(x => x.Subject).HasForeignKey(x => x.SubjectId);
            builder.HasMany<Announcement>(x => x.Announcements).WithOne(x => x.Subject).HasForeignKey(x => x.SubjectId);
        }
    }
}
