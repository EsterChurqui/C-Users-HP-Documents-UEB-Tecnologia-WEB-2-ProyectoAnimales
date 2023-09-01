using SistemaAnimales.Domain.Entities;
using System.Text.RegularExpressions;

namespace SistemaAnimales.Application.Interface.Persistence
{
    public interface IZonaRepository
    {
        void Guardar(Zona zona);

        void Actualizar(Zona zona);
        void Eliminar(int id);

        Task<List<Zona>> GetAll();
    }
}
