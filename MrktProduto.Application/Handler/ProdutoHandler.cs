using MediatR;
using MrktProduto.Application.Handler.Command;
using MrktProduto.Application.Handler.Query;
using MrktProduto.Application.Service;

namespace MrktProduto.Application.ProdutoHandler
{
    public class ProdutoHandler : IRequestHandler<CriarProdutoCommand, CriarProdutoCommandResponse>,
                                IRequestHandler<ListarTodosProdutosQuery, ListarTodosProdutosQueryResponse>,
                                IRequestHandler<BuscarPorIDProdutoQuery, BuscarPorIDProdutoQueryResponse>,
                                IRequestHandler<AtualizarProdutoCommand, AtualizarProdutoCommandResponse>,
                                IRequestHandler<RemoverProdutoCommand, RemoverProdutoCommandResponse>
    {
        private readonly IProdutoService _produtoService;

        public ProdutoHandler(IProdutoService produtoService)
        {
            _produtoService = produtoService;
        }

        public async Task<CriarProdutoCommandResponse> Handle(CriarProdutoCommand request, CancellationToken cancellationToken)
        {
            var result = await this._produtoService.Criar(request.Produto);
            return new CriarProdutoCommandResponse(result);
        }

        public async Task<ListarTodosProdutosQueryResponse> Handle(ListarTodosProdutosQuery request, CancellationToken cancellationToken)
        {
            var result = await this._produtoService.ListarTodos();
            return new ListarTodosProdutosQueryResponse(result);
        }

        public async Task<BuscarPorIDProdutoQueryResponse> Handle(BuscarPorIDProdutoQuery request, CancellationToken cancellationToken)
        {
            var result = await this._produtoService.BuscarPorID(request.Id);
            return new BuscarPorIDProdutoQueryResponse(result);
        }

        public async Task<AtualizarProdutoCommandResponse> Handle(AtualizarProdutoCommand request, CancellationToken cancellationToken)
        {
            var result = await this._produtoService.Atualizar(request.Produto);
            return new AtualizarProdutoCommandResponse(result);
        }

        public async Task<RemoverProdutoCommandResponse> Handle(RemoverProdutoCommand request, CancellationToken cancellationToken)
        {
            var result = await this._produtoService.Remover(request.Id);
            return new RemoverProdutoCommandResponse(result);
        }
    }
}