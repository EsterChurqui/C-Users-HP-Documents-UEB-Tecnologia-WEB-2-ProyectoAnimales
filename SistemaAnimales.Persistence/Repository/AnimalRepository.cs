using SistemaAnimales.Application.Interface.Persistence;
using SistemaAnimales.Domain.Entities;
using SistemaAnimales.Persistence.Context;
using System.Text.RegularExpressions;

namespace SistemaAnimales.Persistence.Repository 
{
    public class AnimalRepository : IAnimalRepository
    {
        private readonly SistemaAnimalesContext _context;

        public AnimalRepository(SistemaAnimalesContext context)
        {
            _context = context;
        }

        public void Actualizar(Animal animal)
        {
            throw new NotImplementedException();
        }

        public void Eliminar(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Animal>> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Guardar(Animal animal)
        {
            _context.Animales.Add(animal);
            _context.SaveChanges();
        }
    }
}
