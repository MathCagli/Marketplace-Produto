using MrktProduto.Domain.Models;
using MrktProduto.Domain.Repository;
using MrktProduto.Repository.Context;
using MrktProduto.Repository.Database;

namespace MrktProduto.Repository.Repository
{
    public class ItemRepository : Repository<Item>, IItemRepository
    {
        public ItemRepository(MrktProdutoContext context) : base(context)
        {
        }
    }
}