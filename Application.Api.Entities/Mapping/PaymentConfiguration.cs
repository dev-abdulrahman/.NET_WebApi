using Application.Api.Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Application.Api.Entities.Mapping
{
    public class PaymentConfiguration : IEntityTypeConfiguration<Payment>
    {
        public void Configure(EntityTypeBuilder<Payment> builder)
        {
            builder.ToTable(nameof(Payment));
            builder.HasKey(a => a.PaymentId);

            builder.Property(a => a.Amount).IsRequired().HasPrecision(18, 2); ;
            builder.Property(a => a.PaymentDate).IsRequired();
            builder.Property(a => a.Status).IsRequired();
            builder.Property(a => a.PaymentMethod).IsRequired(false);

            builder.ConfigureBaseEntity<Payment>();

            builder.HasOne(x => x.Student).WithMany(x => x.Payments).HasForeignKey(x => x.StudentId);
        }
    }
}
