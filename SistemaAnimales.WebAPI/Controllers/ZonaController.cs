using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SistemaAnimales.Application.Features.Zona.Commands.CreateZonaCommand;
using SistemaAnimales.Application.Interface.Persistence;
using SistemaAnimales.Domain.Entities;

namespace SistemaAnimales.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ZonaController : ControllerBase
    {

        private readonly IZonaRepository _repository;

        public ZonaController(IZonaRepository repository)
        {
            _repository = repository;
        }

        [HttpPost]
        public async Task <IActionResult> Guardar (CreateZonaCommandParameters parametro)
        {
            CreateZonaCommand command = new CreateZonaCommand(_repository);
            return Ok(command.Guardar(parametro));

        }

        
    }
}
