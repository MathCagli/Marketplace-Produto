using MediatR;
using Microsoft.AspNetCore.Mvc;
using MrktProduto.Application.DTO;
using MrktProduto.Application.Handler.Command;
using MrktProduto.Application.Handler.Query;

namespace MrktProduto.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ItemController : ControllerBase
    {
        private readonly IMediator mediator;

        public ItemController(IMediator mediator)
        {
            this.mediator = mediator;
        }

        [HttpPost("Criar")]
        public async Task<IActionResult> Criar(ItemInputDto dto)
        {
            var result = await this.mediator.Send(new CriarItemCommand(dto));
            return Created($"{result.Item.Id}", result.Item);
        }

        [HttpGet("ListarTodos")]
        public async Task<IActionResult> ListarTodos()
        {
            return Ok(await this.mediator.Send(new ListarTodosItensQuery()));
        }

        [HttpGet("BuscarPorID/{id}")]
        public async Task<IActionResult> BuscarPorID(string id)
        {
            return Ok(await this.mediator.Send(new BuscarPorIDItemQuery { Id = id }));
        }

        [HttpPut("Atualizar")]
        public async Task<IActionResult> Atualizar(ItemOutputDto dto)
        {
            var result = await this.mediator.Send(new AtualizarItemCommand(dto));
            return Ok(result);
        }

        [HttpDelete("Remover/{id}")]
        public async Task<IActionResult> Remover(string id)
        {
            return Ok(await this.mediator.Send(new RemoverItemCommand { Id = id }));
        }
    }
}