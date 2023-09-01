using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SistemaAnimales.Domain.Entities;
using System.Text.RegularExpressions;

namespace SistemaAnimales.Persistence.Configurations
{
  public class ZonaConfig : IEntityTypeConfiguration<Zona>
    {
        public void Configure(EntityTypeBuilder<Zona> builder)
        {
            builder.ToTable("Zona");

            builder.HasKey(x => x.IdZona);

            builder.Property(x => x.Pais)
                .IsRequired()
                .HasMaxLength(40);

            builder.Property(x => x.Departamento)
                .IsRequired()
                .HasMaxLength(100);


        }
    }
}
