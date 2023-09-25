using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infraestructure.Data.Conf;
public class DepartmentConfig : IEntityTypeConfiguration<Department>
{
    public void Configure(EntityTypeBuilder<Department> builder)
    {
        builder.ToTable("department");
        builder.HasKey(e => e.Id);
        builder.Property(e => e.Id);

        builder.Property(p => p.Name)
        .IsRequired()
        .HasMaxLength(50);
        
        builder.HasOne(p => p.Countries)
        .WithMany(p => p.Departments)
        .HasForeignKey(p => p.IdCountryFk);
    }
}