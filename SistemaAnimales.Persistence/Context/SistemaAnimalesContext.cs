using Microsoft.EntityFrameworkCore;
using SistemaAnimales.Domain;
using SistemaAnimales.Domain.Entities;
using SistemaAnimales.Persistence.Configurations;

namespace SistemaAnimales.Persistence.Context
{
    public class SistemaAnimalesContext : DbContext
    {
        public SistemaAnimalesContext(DbContextOptions<SistemaAnimalesContext> options) : base(options)
        {

        }

        public virtual DbSet<Animal> Animales { get; set; }

        public virtual DbSet<Desaparicion> Desapariciones { get; set; }

        public virtual DbSet<Refugio> Refugios { get; set; }

        public virtual DbSet<Zona> Zonas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //En base a la carpeta Configurations del Proyecto SistemaAnimales.Persistence

            new AnimalConfig().Configure(modelBuilder.Entity<Animal>());
            new DesaparicionConfig().Configure(modelBuilder.Entity<Desaparicion>());
            new RefugioConfig().Configure(modelBuilder.Entity<Refugio>());
            new ZonaConfig().Configure(modelBuilder.Entity<Zona>());

        }

    }
}
