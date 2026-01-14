using Application.Api.Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Application.Api.Entities.Mapping
{
    public static class BaseEntityConfiguration
    {
        public static void ConfigureBaseEntity<TEntity>(this EntityTypeBuilder<TEntity> builder)
            where TEntity : BaseEntity
        {
            builder.Property(e => e.IsActive).IsRequired().HasDefaultValue(true);
            builder.Property(e => e.CreatedDate).IsRequired().HasDefaultValueSql("GETDATE()");
            builder.Property(e => e.CreatedBy).IsRequired().HasDefaultValue(1);
            builder.Property(e => e.LastModifiedDate).IsRequired().HasDefaultValueSql("GETDATE()");
            builder.Property(e => e.LastModifiedBy).IsRequired().HasDefaultValue(1);
        }
    }
}
