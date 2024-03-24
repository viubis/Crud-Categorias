using Categorias.Domain.Commands.AtualizarCategoria;
using Categorias.Domain.Commands.Categorias.Adicionar;
using Categorias.Domain.Commands.ListarCategorias;
using Categorias.Domain.Commands.ObterCategoria;
using Categorias.Domain.Commands.RemoverCategoria;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Categorias.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriaController : ControllerBase
    {
        private readonly IMediator _mediator;

        public CategoriaController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("listar")]
        public async Task<IActionResult> Listar()
        {
            var listaCategoria = await _mediator.Send(new ListarCategoriaRequest());
            return Ok(listaCategoria);
        }


        [HttpPost("adicionar")]
        public async Task<IActionResult> Adicionar(AdicionarCategoriaRequest request)
        {
            var response = await _mediator.Send(request);
            if (response.Success)
                return Created("", response);
            return BadRequest(response);
        }

        [HttpGet("obter/{id}")]
        public async Task<IActionResult> Obter(Guid id)
        {
            var categoria = await _mediator.Send(new ObterCategoriaRequest(id));
            return Ok(categoria);
        }

        [HttpDelete("remover/{id}")]
        public async Task<IActionResult> Remover(Guid id)
        {
            var response = await _mediator.Send(new RemoverCategoriaRequest(id));
            if (response.Success)
            {
                return Ok(response);
            }

            return BadRequest(response);
        }

        [HttpPut("atualizar")]
        public async Task<IActionResult> Atualizar(AtualizarCategoriaRequest request)
        {
            var response = await _mediator.Send(request);
            if (response.Success)
            {
                return Ok(response);
            }

            return BadRequest(response);
        }
    }
}
