using MediatR;
using Microsoft.AspNetCore.Mvc;
using MrktProduto.Application.DTO;
using MrktProduto.Application.Handler.Command;
using MrktProduto.Application.Handler.Query;

namespace MrktProduto.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProdutoController : ControllerBase
    {
        private readonly IMediator mediator;

        public ProdutoController(IMediator mediator)
        {
            this.mediator = mediator;
        }

        [HttpPost("Criar")]
        public async Task<IActionResult> Criar(ProdutoInputDto dto)
        {
            var result = await this.mediator.Send(new CriarProdutoCommand(dto));
            return Created($"{result.Produto.Id}", result.Produto);
        }

        [HttpGet("ListarTodos")]
        public async Task<IActionResult> ListarTodos()
        {
            return Ok(await this.mediator.Send(new ListarTodosProdutosQuery()));
        }

        [HttpGet("BuscarPorID/{id}")]
        public async Task<IActionResult> BuscarPorID(string id)
        {
            return Ok(await this.mediator.Send(new BuscarPorIDProdutoQuery { Id = id }));
        }

        [HttpPut("Atualizar")]
        public async Task<IActionResult> Atualizar(ProdutoOutputDto dto)
        {
            var result = await this.mediator.Send(new AtualizarProdutoCommand(dto));
            return Ok(result);
        }

        [HttpDelete("Remover/{id}")]
        public async Task<IActionResult> Remover(string id)
        {
            return Ok(await this.mediator.Send(new RemoverProdutoCommand { Id = id }));
        }
    }
}