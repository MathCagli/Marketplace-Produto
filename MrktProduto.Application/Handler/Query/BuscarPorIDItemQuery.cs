using MediatR;
using MrktProduto.Application.DTO;

namespace MrktProduto.Application.Handler.Query
{
    public class BuscarPorIDItemQuery : IRequest<BuscarPorIDItemQueryResponse>
    {
        public string Id { get; set; }
    }

    public class BuscarPorIDItemQueryResponse
    {
        public ItemOutputDto Item { get; set; }

        public BuscarPorIDItemQueryResponse(ItemOutputDto item)
        {
            Item = item;
        }
    }
}