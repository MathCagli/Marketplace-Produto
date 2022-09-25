using MediatR;
using MrktProduto.Application.DTO;

namespace MrktProduto.Application.Handler.Command
{
    public class CriarProdutoCommand : IRequest<CriarProdutoCommandResponse>
    {
        public ProdutoInputDto Produto { get; set; }

        public CriarProdutoCommand(ProdutoInputDto produto)
        {
            Produto = produto;
        }
    }

    public class CriarProdutoCommandResponse
    {
        public ProdutoOutputDto Produto { get; set; }

        public CriarProdutoCommandResponse(ProdutoOutputDto produto)
        {
            Produto = produto;
        }
    }
}