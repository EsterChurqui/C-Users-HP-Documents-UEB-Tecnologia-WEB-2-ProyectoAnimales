using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SistemaAnimales.Domain.Entities;

namespace SistemaAnimales.Persistence.Configurations
{
    public class DesaparicionConfig : IEntityTypeConfiguration<Desaparicion>
    {

        public void Configure(EntityTypeBuilder<Desaparicion> builder)
        {


            builder.ToTable("Desaparicion");

            builder.HasKey(x => x.IdDesaparicion);


            builder.Property(x => x.IdUsuario)
                .IsRequired()
                .HasMaxLength(20);


            builder.Property(x => x.NombreAnimal)
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(x => x.Foto)
                .IsRequired()
                .HasMaxLength(300);


            builder.Property(x => x.FechaDesaparicion)
                .IsRequired();

            builder.Property(x => x.Edad)
                .IsRequired();

            builder.Property(x => x.Contacto) //# de contacto
              .IsRequired()
              .HasMaxLength(20);


            builder.Property(x => x.Otros)
                .IsRequired()
                .HasMaxLength(150);

            builder.Property(x => x.Eliminado);
          
        }
    }
}
