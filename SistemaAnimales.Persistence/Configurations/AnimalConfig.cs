using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SistemaAnimales.Domain.Entities;

namespace SistemaAnimales.Persistence.Configurations
{
    public class AnimalConfig : IEntityTypeConfiguration<Animal>
    {
        public void Configure(EntityTypeBuilder<Animal> builder)

        {
            builder.ToTable("Animal");

            builder.HasKey(x => x.IdAnimal);


            builder.Property(x => x.NombreAnimal)
                .IsRequired()
                .HasMaxLength(50);

            builder.Property(x => x.Foto)
                .IsRequired()
                .HasMaxLength(300);


            builder.Property(x => x.Especie)
                .IsRequired()
                .HasMaxLength(50);

            builder.Property(x => x.Edad)

                .IsRequired();

            builder.Property(x => x.Genero)
              .IsRequired()
              .HasMaxLength(10);

            builder.Property(x => x.Descripcion)
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(x => x.Estado)
                .IsRequired()
                .HasMaxLength(30);
            // roba la llave de refugio
            builder.HasOne(x => x.refugio)
                .WithMany(x => x.Animales)
                .HasForeignKey(x => x.IdRefugio);


        }
    }
}
