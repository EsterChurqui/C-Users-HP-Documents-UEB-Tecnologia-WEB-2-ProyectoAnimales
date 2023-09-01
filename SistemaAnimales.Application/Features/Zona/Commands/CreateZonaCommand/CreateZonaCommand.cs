using SistemaAnimales.Application.Interface.Persistence;
using SistemaAnimales.Application.Wrappers;
using SistemaAnimales.Domain.Entities;

namespace SistemaAnimales.Application.Features.Zona.Commands.CreateZonaCommand
{
    public class CreateZonaCommand
    {

        private readonly IZonaRepository _zonaRepository;

        public CreateZonaCommand(IZonaRepository zonaRepository)
        {
            _zonaRepository = zonaRepository;
        }
        public Response<SistemaAnimales.Domain.Entities.Zona>Guardar(CreateZonaCommandParameters parametros)
        {
            SistemaAnimales.Domain.Entities.Zona objZona = new SistemaAnimales.Domain.Entities.Zona();

            objZona.Pais = parametros.Pais;
            objZona.Departamento = parametros.Departamento;

            _zonaRepository.Guardar(objZona);

            return new Response<SistemaAnimales.Domain.Entities.Zona>(objZona);


        }
    }
}
