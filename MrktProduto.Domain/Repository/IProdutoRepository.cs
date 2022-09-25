using MrktProduto.CrossCutting.Repository;
using MrktProduto.Domain.Models;

namespace MrktProduto.Domain.Repository
{
    public interface IProdutoRepository : IRepository<Produto>
    {
    }
}