using MrktProduto.CrossCutting.Entity;

namespace MrktProduto.Domain.Models
{
    public class Item : Entity<Guid>
    {
        public decimal Valor { get; set; }
        public int QtdPedida { get; set; }

        public virtual IList<Produto> Produtos { get; set; }
    }
}