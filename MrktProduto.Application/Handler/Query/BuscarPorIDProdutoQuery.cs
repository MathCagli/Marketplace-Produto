using MediatR;
using MrktProduto.Application.DTO;

namespace MrktProduto.Application.Handler.Query
{
    public class BuscarPorIDProdutoQuery : IRequest<BuscarPorIDProdutoQueryResponse>
    {
        public string Id { get; set; }
    }

    public class BuscarPorIDProdutoQueryResponse
    {
        public ProdutoOutputDto Produto { get; set; }

        public BuscarPorIDProdutoQueryResponse(ProdutoOutputDto produto)
        {
            Produto = produto;
        }
    }
}
