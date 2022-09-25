using MediatR;
using MrktProduto.Application.DTO;

namespace MrktProduto.Application.Handler.Command
{
    public class CriarItemCommand : IRequest<CriarItemCommandResponse>
    {
        public ItemInputDto Item { get; set; }

        public CriarItemCommand(ItemInputDto item)
        {
            Item = item;
        }
    }

    public class CriarItemCommandResponse
    {
        public ItemOutputDto Item { get; set; }

        public CriarItemCommandResponse(ItemOutputDto item)
        {
            Item = item;
        }
    }
}