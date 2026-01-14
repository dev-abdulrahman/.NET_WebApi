using Application.Api.Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Application.Api.Entities.Mapping
{
    public class CountryConfiguration : IEntityTypeConfiguration<Country>
    {
        public void Configure(EntityTypeBuilder<Country> builder)
        {
            builder.ToTable("Country");
            builder.HasKey(a => a.CountryId);
         
            builder.Property(a => a.Name).IsRequired().HasMaxLength(100);
            
            builder.ConfigureBaseEntity<Country>();
        }
    }
}
