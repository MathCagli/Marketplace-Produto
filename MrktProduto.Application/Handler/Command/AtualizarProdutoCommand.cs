using MediatR;
using MrktProduto.Application.DTO;

namespace MrktProduto.Application.Handler.Command
{
    public class AtualizarProdutoCommand : IRequest<AtualizarProdutoCommandResponse>
    {
        public ProdutoOutputDto Produto { get; set; }

        public AtualizarProdutoCommand(ProdutoOutputDto produto)
        {
            Produto = produto;
        }
    }

    public class AtualizarProdutoCommandResponse
    {
        public ProdutoOutputDto Produto { get; set; }

        public AtualizarProdutoCommandResponse(ProdutoOutputDto produto)
        {
            Produto = produto;
        }
    }
}