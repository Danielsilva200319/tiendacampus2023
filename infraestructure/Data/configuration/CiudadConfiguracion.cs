using core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace infraestructure.Data.Configuracion;

public class ciudadConfiguracion : IEntityTypeConfiguration<Ciudad>
{
    public void Configure(EntityTypeBuilder<Ciudad> builder)
    {
        builder.ToTable("ciudad");

        builder.HasKey(e => e.Id);
        builder.Property(e => e.Id);

        builder.Property(p => p.Nombre)
        .IsRequired()
        .HasMaxLength(50);

        builder.HasOne(p => p.Departamento)
        .WithMany(p => p.Ciudades)
        .HasForeignKey(p => p.IdDepartamentoFk);
    }
}