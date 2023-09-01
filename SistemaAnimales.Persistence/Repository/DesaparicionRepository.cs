using SistemaAnimales.Application.Interface.Persistence;
using SistemaAnimales.Domain.Entities;
using SistemaAnimales.Persistence.Context;
using System.Text.RegularExpressions;

namespace SistemaAnimales.Persistence.Repository
{
    public class DesaparicionRepository : IDesaparicionRepository
    {
        private readonly SistemaAnimalesContext _context;

        public DesaparicionRepository(SistemaAnimalesContext context)
        {
            _context = context;
        }

        public void Actualizar(Desaparicion desaparicion)
        {
            throw new NotImplementedException();
        }

        public void Eliminar(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Desaparicion>> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Guardar(Desaparicion desaparicion)
        {
            _context.Desapariciones.Add(desaparicion);
            _context.SaveChanges();
        }
    }
}
