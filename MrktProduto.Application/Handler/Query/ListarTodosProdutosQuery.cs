using MediatR;
using MrktProduto.Application.DTO;

namespace MrktProduto.Application.Handler.Query
{
    public class ListarTodosProdutosQuery : IRequest<ListarTodosProdutosQueryResponse>
    {
    }

    public class ListarTodosProdutosQueryResponse
    {
        public IList<ProdutoOutputDto> Produtos { get; set; }

        public ListarTodosProdutosQueryResponse(IList<ProdutoOutputDto> produtos)
        {
            Produtos = produtos;
        }
    }
}
