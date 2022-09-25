using System.ComponentModel.DataAnnotations;

namespace MrktProduto.Application.DTO
{
    public record ItemInputDto([Required(ErrorMessage = "Valor é obrigatório!")] decimal Valor,
        [Required(ErrorMessage = "Quantidade pedida é obrigatória!")] int QtdPedida, List<ProdutoInputDto> Produtos);
    public record ItemOutputDto(Guid Id, decimal Valor, int QtdPedida);
}