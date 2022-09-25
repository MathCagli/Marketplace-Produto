using AutoMapper;
using MrktProduto.Application.DTO;
using MrktProduto.Domain.Repository;
using MrktProduto.Domain.Models;

namespace MrktProduto.Application.Service
{
    public class ItemService : IItemService
    {
        private readonly IItemRepository itemRepository;
        private readonly IMapper mapper;

        public ItemService(IItemRepository itemRepository, IMapper mapper)
        {
            this.itemRepository = itemRepository;
            this.mapper = mapper;
        }

        public async Task<ItemOutputDto> Criar(ItemInputDto dto)
        {
            var item = this.mapper.Map<Item>(dto);
            await this.itemRepository.Save(item);
            return this.mapper.Map<ItemOutputDto>(item);
        }

        public async Task<List<ItemOutputDto>> ListarTodos()
        {
            var item = await this.itemRepository.GetAll();
            return this.mapper.Map<List<ItemOutputDto>>(item);
        }

        public async Task<ItemOutputDto> BuscarPorID(string id)
        {
            var item = await this.itemRepository.Get(id);
            return this.mapper.Map<ItemOutputDto>(item);
        }

        public async Task<ItemOutputDto> Atualizar(ItemOutputDto dto)
        {
            var item = this.mapper.Map<Item>(dto);
            await this.itemRepository.Update(item);
            return this.mapper.Map<ItemOutputDto>(item);
        }

        public async Task<string> Remover(string id)
        {
            var item = await this.itemRepository.Get(id);
            await this.itemRepository.Delete(item);
            return id;
        }
    }
}