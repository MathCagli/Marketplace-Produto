using MrktProduto.Application.DTO;

namespace MrktProduto.Application.Service
{
    public interface IItemService
    {
        Task<ItemOutputDto> Criar(ItemInputDto dto);
        Task<List<ItemOutputDto>> ListarTodos();
        Task<ItemOutputDto> BuscarPorID(string id);
        Task<ItemOutputDto> Atualizar(ItemOutputDto dto);
        Task<string> Remover(string id);
    }
}