using SistemaAnimales.Application.Interface.Persistence;
using SistemaAnimales.Domain.Entities;
using SistemaAnimales.Persistence.Context;
using System.Text.RegularExpressions;

namespace SistemaAnimales.Persistence.Repository
{
    public class ZonaRepository : IZonaRepository 
    {
        private readonly SistemaAnimalesContext _context;

        public ZonaRepository(SistemaAnimalesContext context)
        {
            _context = context;
        }

        public void Actualizar(Zona zona)
        {
            throw new NotImplementedException();
        }

        public void Eliminar(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Zona>> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Guardar(Zona marca)
        {
            _context.Zonas.Add(marca);
            _context.SaveChanges();
        }
    }
}
