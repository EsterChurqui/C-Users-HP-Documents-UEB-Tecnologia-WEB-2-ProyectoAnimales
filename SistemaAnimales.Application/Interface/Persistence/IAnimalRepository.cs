using SistemaAnimales.Domain.Entities;
using System.Text.RegularExpressions;

namespace SistemaAnimales.Application.Interface.Persistence
{
    public interface IAnimalRepository
    {
        void Guardar(Animal animal);

        void Actualizar(Animal animal);
        void Eliminar(int id);

        Task<List<Animal>> GetAll();
    }
}
