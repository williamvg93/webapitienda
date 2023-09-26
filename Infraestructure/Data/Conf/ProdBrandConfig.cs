using Core.Entities;

namespace Infraestructure.Data.Conf;
public class ProdBrandConfig : IEntityTypeConfiguration<ProdBrand>
{
    public void Configure(EntityTypeBuilder<ProdBrand> builder)
    {
        builder.ToTable("productbrand");

        builder.HasKey(i => i.Id);
        builder.Property(i => i.Id);

        builder.Property(n => n.Name)
        .IsRequired()
        .HasMaxLength(50);
    }
}

