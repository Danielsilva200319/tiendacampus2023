using core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace infraestructure.Data.Configuracion
{
    public class CiudadConfiguracion : IEntityTypeConfiguration<Ciudad>
    {
        public void Configure(EntityTypeBuilder<Ciudad> builder)
        {
            builder.ToTable("Ciudades"); // Cambié el nombre de la tabla a plural (por convención)

            builder.HasKey(e => e.Id);
            
            builder.Property(e => e.Id)
                .ValueGeneratedOnAdd(); // Especifique que la propiedad "Id" es auto-generada

            builder.Property(p => p.Nombre)
                .IsRequired()
                .HasMaxLength(50);

            builder.HasOne(p => p.Departamento)
                .WithMany(d => d.Ciudades)
                .HasForeignKey(p => p.IdDepartamentoFk);
        }
    }
}
