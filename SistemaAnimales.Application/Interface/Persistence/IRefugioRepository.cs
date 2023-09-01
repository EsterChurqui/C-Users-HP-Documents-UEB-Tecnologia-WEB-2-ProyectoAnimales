using SistemaAnimales.Domain.Entities;
using System.Text.RegularExpressions;

namespace SistemaAnimales.Application.Interface.Persistence
{
    public interface IRefugioRepository
    {
        void Guardar(Refugio refugio);

        void Actualizar(Refugio refugio);
        void Eliminar(int id);

        Task<List<Refugio>> GetAll();
    }
}
