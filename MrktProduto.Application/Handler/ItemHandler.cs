using MediatR;
using MrktProduto.Application.Handler.Command;
using MrktProduto.Application.Handler.Query;
using MrktProduto.Application.Service;

namespace MrktProduto.Application.ItemHandler
{
    public class ItemHandler : IRequestHandler<CriarItemCommand, CriarItemCommandResponse>,
                                IRequestHandler<ListarTodosItensQuery, ListarTodosItensQueryResponse>,
                                IRequestHandler<BuscarPorIDItemQuery, BuscarPorIDItemQueryResponse>,
                                IRequestHandler<AtualizarItemCommand, AtualizarItemCommandResponse>,
                                IRequestHandler<RemoverItemCommand, RemoverItemCommandResponse>
    {
        private readonly IItemService _itemService;

        public ItemHandler(IItemService itemService)
        {
            _itemService = itemService;
        }

        public async Task<CriarItemCommandResponse> Handle(CriarItemCommand request, CancellationToken cancellationToken)
        {
            var result = await this._itemService.Criar(request.Item);
            return new CriarItemCommandResponse(result);
        }

        public async Task<ListarTodosItensQueryResponse> Handle(ListarTodosItensQuery request, CancellationToken cancellationToken)
        {
            var result = await this._itemService.ListarTodos();
            return new ListarTodosItensQueryResponse(result);
        }

        public async Task<BuscarPorIDItemQueryResponse> Handle(BuscarPorIDItemQuery request, CancellationToken cancellationToken)
        {
            var result = await this._itemService.BuscarPorID(request.Id);
            return new BuscarPorIDItemQueryResponse(result);
        }

        public async Task<AtualizarItemCommandResponse> Handle(AtualizarItemCommand request, CancellationToken cancellationToken)
        {
            var result = await this._itemService.Atualizar(request.Item);
            return new AtualizarItemCommandResponse(result);
        }

        public async Task<RemoverItemCommandResponse> Handle(RemoverItemCommand request, CancellationToken cancellationToken)
        {
            var result = await this._itemService.Remover(request.Id);
            return new RemoverItemCommandResponse(result);
        }
    }
}