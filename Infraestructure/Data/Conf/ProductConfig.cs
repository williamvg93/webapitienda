using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace Infraestructure.Data.Conf;

public class ProductConfig : IEntityTypeConfiguration<Product>
{
    public void Configure(EntityTypeBuilder<Product> builder)
    {
        builder.ToTable("product");

        builder.HasKey(i => i.Code);
        builder.Property(i => i.Code)
        .HasMaxLength(10);

        builder.Property(n => n.Name)
        .IsRequired()
        .HasMaxLength(50);

        builder.HasOne(ipb => ipb.ProductBrand)
        .WithMany(idp => idp.Products)
        .HasForeignKey(idp => idp.IdProdBrandFk);
    }
}
