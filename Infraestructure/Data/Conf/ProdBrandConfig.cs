using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infraestructure.Data.Conf;
public class ProdBrandConfig : IEntityTypeConfiguration<ProductBrand>
{
    public void Configure(EntityTypeBuilder<ProductBrand> builder)
    {
        builder.ToTable("productbrand");

        builder.HasKey(i => i.Id);
        builder.Property(i => i.Id);

        builder.Property(n => n.Name)
        .IsRequired()
        .HasMaxLength(50);
    }
}

/* 
namespace Infraestructure.Data.Conf;
public class CityConfiguration : IEntityTypeConfiguration<City>
{
    public void Configure(EntityTypeBuilder<City> builder)
    {
        builder.ToTable("city");
        
        builder.HasKey(e => e.Id);
        builder.Property(e => e.Id);

        builder.Property(p => p.Name)
        .IsRequired()
        .HasMaxLength(50);

        builder.HasOne(p => p.Departments)
        .WithMany(p => p.Cities)
        .HasForeignKey(p => p.IdDepartFk);
    }
}
 */