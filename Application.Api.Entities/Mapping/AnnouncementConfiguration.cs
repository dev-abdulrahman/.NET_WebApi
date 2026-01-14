using Application.Api.Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Application.Api.Entities.Mapping
{
    public class AnnouncementConfiguration : IEntityTypeConfiguration<Announcement>
    {
        public void Configure(EntityTypeBuilder<Announcement> builder)
        {
            builder.ToTable(nameof(Announcement));
            builder.HasKey(a => a.AnnouncementId);

            builder.Property(a => a.Title).IsRequired().HasMaxLength(200);
            builder.Property(a => a.Message).IsRequired().HasMaxLength(2000);
            builder.Property(a => a.PostedDate).IsRequired();

            builder.ConfigureBaseEntity<Announcement>();

            // Foreign Keys
            builder.Property(x => x.SubjectId).IsRequired();

            // Navigation Properties
            builder.HasOne<Subject>().WithMany(x => x.Announcements).HasForeignKey(a => a.SubjectId);
        }
    }
}
