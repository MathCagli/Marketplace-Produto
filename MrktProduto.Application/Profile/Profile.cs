using MrktProduto.Application.DTO;
using MrktProduto.Domain.Models;

namespace MrktProduto.Application.Profile
{
    public class Profile : AutoMapper.Profile
    {
        public Profile()
        {
            // Item
            CreateMap<ItemInputDto, Item>();
            CreateMap<Item, ItemOutputDto>();
            CreateMap<ItemOutputDto, Item>();

            // Produto
            CreateMap<ProdutoInputDto, Produto>();
            CreateMap<Produto, ProdutoOutputDto>();
            CreateMap<ProdutoOutputDto, Produto>();
        }
    }
}