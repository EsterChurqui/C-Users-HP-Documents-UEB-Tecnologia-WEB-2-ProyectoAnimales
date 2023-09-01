using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SistemaAnimales.Domain.Entities;

namespace SistemaAnimales.Persistence.Configurations
{
   public class RefugioConfig : IEntityTypeConfiguration<Refugio>
    {
        public void Configure(EntityTypeBuilder<Refugio> builder)

        {
            builder.ToTable("Refugio");

            builder.HasKey(x => x.IdRefugio);

            builder.Property(x => x.IdUsuario)
              .IsRequired()
              .HasMaxLength(20);

            builder.Property(x => x.NombreRefugio)
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(x => x.Foto)
                .IsRequired()
                .HasMaxLength(300);

            builder.Property(x => x.Direccion)
                .IsRequired()
                .HasMaxLength(200);

            builder.Property(x => x.Telefono)
                .IsRequired();

            builder.Property(x => x.CorreoElectronico)
                .HasMaxLength(30);

            builder.Property(x => x.Presentacion)
                .IsRequired()
                .HasMaxLength(300);

            //aqui se roba la llave 
            builder.HasOne(x => x.zona) // Cambiado "zona" a "Zona" para seguir las convenciones de nomenclatura de C#
             .WithMany() // No es necesario especificar una colección en "WithMany" si "Zona" no tiene una colección de "Refugio"
             .HasForeignKey(x => x.IdZona); // Cambiado "x.id" a "x.IdZona" para reflejar la clave foránea



        }
    }
}
