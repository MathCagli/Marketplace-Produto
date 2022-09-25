using MrktProduto.CrossCutting.Entity;

namespace MrktProduto.Domain.Models
{
    public class Produto : Entity<Guid>
    {
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public string Imagem { get; set; }
        public int QtdEstoque { get; set; }
        public decimal Valor { get; set; }
    }
}