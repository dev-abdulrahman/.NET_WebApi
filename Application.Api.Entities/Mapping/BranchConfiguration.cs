using Application.Api.Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Application.Api.Entities.Mapping
{
    public class BranchConfiguration : IEntityTypeConfiguration<Branch>
    {
        public void Configure(EntityTypeBuilder<Branch> builder)
        {
            builder.ToTable(nameof(Branch));
            builder.HasKey(a => a.BranchId);

            builder.Property(a => a.Name).IsRequired().HasMaxLength(200);
            builder.Property(a => a.Description).IsRequired().HasMaxLength(2000);

            builder.ConfigureBaseEntity<Branch>();

            builder.HasMany<Subject>().WithOne(x => x.Branch).HasForeignKey(x => x.BranchId);
        }
    }
}
