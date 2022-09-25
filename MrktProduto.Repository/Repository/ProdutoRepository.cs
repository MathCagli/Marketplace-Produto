using MrktProduto.Domain.Models;
using MrktProduto.Domain.Repository;
using MrktProduto.Repository.Context;
using MrktProduto.Repository.Database;

namespace MrktProduto.Repository.Repository
{
    public class ProdutoRepository : Repository<Produto>, IProdutoRepository
    {
        public ProdutoRepository(MrktProdutoContext context) : base(context)
        {
        }
    }
}