using Microsoft.AspNetCore.Mvc;
using MediatR;
using TiendaServicios.Api.Autor.Aplicacion;
using TiendaServicios.Api.Autor.Modelo;

namespace TiendaServicios.Api.Autor.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AutorControler : Controller
    {
        private readonly IMediator _mediator;
        public AutorControler(IMediator mediator)
        {
            _mediator = mediator;
        }
        //Crear Autor
        [HttpPost]
        public async Task<ActionResult<Unit>> Crear(Nuevo.Ejecuta data)
        {
            return await _mediator.Send(data);
        }
        //Obtener lista de Autores
        [HttpGet]
        public async Task<ActionResult<List<AutorDto>>> GetAutores()
        {
            return await _mediator.Send(new Consulta.ListaAutor());
        }
        //Obtener un Autor
        [HttpGet("{id}")]
        public async Task<ActionResult<AutorDto>> GetAutor(string id)
        {
            return await _mediator.Send(new ConsultaFiltro.AutorUnico{AutorGuid = id});
        }
    }
}
