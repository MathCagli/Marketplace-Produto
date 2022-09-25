using MediatR;

namespace MrktProduto.Application.Handler.Command
{
    public class RemoverItemCommand : IRequest<RemoverItemCommandResponse>
    {
        public string Id { get; set; }
    }

    public class RemoverItemCommandResponse
    {
        public string Id { get; set; }

        public RemoverItemCommandResponse(string id)
        {
            Id = id;
        }
    }
}