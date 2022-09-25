using MediatR;
using MrktProduto.Application.DTO;

namespace MrktProduto.Application.Handler.Query
{
    public class ListarTodosItensQuery : IRequest<ListarTodosItensQueryResponse>
    {
    }

    public class ListarTodosItensQueryResponse
    {
        public IList<ItemOutputDto> Itens { get; set; }

        public ListarTodosItensQueryResponse(IList<ItemOutputDto> itens)
        {
            Itens = itens;
        }
    }
}
