using SistemaAnimales.Domain.Entities;
using System.Text.RegularExpressions;

namespace SistemaAnimales.Application.Interface.Persistence
{
    public interface IDesaparicionRepository
    {
        void Guardar(Desaparicion desaparicion);

        void Actualizar(Desaparicion desaparicion);
        void Eliminar(int id);

        Task<List<Desaparicion>> GetAll();
    }
}
