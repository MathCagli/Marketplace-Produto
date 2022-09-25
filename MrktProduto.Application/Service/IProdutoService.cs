using MrktProduto.Application.DTO;

namespace MrktProduto.Application.Service
{
    public interface IProdutoService
    {
        Task<ProdutoOutputDto> Criar(ProdutoInputDto dto);
        Task<List<ProdutoOutputDto>> ListarTodos();
        Task<ProdutoOutputDto> BuscarPorID(string id);
        Task<ProdutoOutputDto> Atualizar(ProdutoOutputDto dto);
        Task<string> Remover(string id);
    }
}