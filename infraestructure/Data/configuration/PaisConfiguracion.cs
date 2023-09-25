using core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace infraestructure.Data.Configuracion;

public class PaisConfiguracion : IEntityTypeConfiguration<Pais>
{

    public void Configure(EntityTypeBuilder<Pais> builder)
    {
        // Aqui puedes configurar las propiedades de la entidad Marca
        // utilizando el objeto 'builder'
        builder.ToTable("Pais");

        builder.HasKey(e => e.Id);
        builder.Property(e => e.Id);

        builder.Property(p => p.Nombre)
        .IsRequired()
        .HasMaxLength(50);
    }
}