using MediatR;
using MrktProduto.Application.DTO;

namespace MrktProduto.Application.Handler.Command
{
    public class AtualizarItemCommand : IRequest<AtualizarItemCommandResponse>
    {
        public ItemOutputDto Item { get; set; }

        public AtualizarItemCommand(ItemOutputDto item)
        {
            Item = item;
        }
    }

    public class AtualizarItemCommandResponse
    {
        public ItemOutputDto Item { get; set; }

        public AtualizarItemCommandResponse(ItemOutputDto item)
        {
            Item = item;
        }
    }
}