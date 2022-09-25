using System.ComponentModel.DataAnnotations;

namespace MrktProduto.Application.DTO
{
    public record ProdutoInputDto([Required(ErrorMessage = "Nome é obrigatório!")] string Nome, 
        [Required(ErrorMessage = "Descrição é obrigatória!")] string Descricao, 
        [Required(ErrorMessage = "Imagem é obrigatório!")] string Imagem, 
        [Required(ErrorMessage = "Quantidade em estoque é obrigatória!")] int QtdEstoque, 
        [Required(ErrorMessage = "Sexo é obrigatório!")] decimal Valor);
    public record ProdutoOutputDto(Guid Id, string Nome, string Descricao, string Imagem, int QtdEstoque, decimal Valor);
}