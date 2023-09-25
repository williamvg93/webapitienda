using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infraestructure.Data.Conf;
public class CountryConfig : IEntityTypeConfiguration<Country>
{
    public void Configure(EntityTypeBuilder<Country> builder)
    {
        builder.ToTable("country");
        
        builder.HasKey(e => e.Id);
        builder.Property(e => e.Id);

        builder.Property(p => p.Name)
        .IsRequired()
        .HasMaxLength(50);
    }
}


