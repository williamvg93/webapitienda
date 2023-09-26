using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace Infraestructure.Data.Conf;

public class PreseTypeConfig : IEntityTypeConfiguration<PresentationType>
{
    public void Configure(EntityTypeBuilder<PresentationType> builder)
    {
        builder.ToTable("presentationtype");

        builder.HasKey(id => id.Id);
        builder.Property(id => id.Id);

        builder.Property(na => na.Name)
        .IsRequired()
        .HasMaxLength(50);
    }
}