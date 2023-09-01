using SistemaAnimales.Application.Interface.Persistence;
using SistemaAnimales.Domain.Entities;
using SistemaAnimales.Persistence.Context;
using System.Text.RegularExpressions;

namespace SistemaAnimales.Persistence.Repository
{
    public class RefugioRepository
    {

        private readonly SistemaAnimalesContext _context;

        public RefugioRepository(SistemaAnimalesContext context)
        {
            _context = context;
        }

        public void Actualizar(Refugio refugio)
        {
            throw new NotImplementedException();
        }

        public void Eliminar(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Refugio>> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Guardar(Refugio refugio)
        {
            _context.Refugios.Add(refugio);
            _context.SaveChanges();
        }
    }
}
