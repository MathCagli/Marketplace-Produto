using MediatR;

namespace MrktProduto.Application.Handler.Command
{
    public class RemoverProdutoCommand : IRequest<RemoverProdutoCommandResponse>
    {
        public string Id { get; set; }
    }

    public class RemoverProdutoCommandResponse
    {
        public string Id { get; set; }

        public RemoverProdutoCommandResponse(string id)
        {
            Id = id;
        }
    }
}