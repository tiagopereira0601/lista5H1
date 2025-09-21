using System.ComponentModel.DataAnnotations;

namespace WebApp.Models
{
    public class Produto
    {
        [Required(ErrorMessage = "Descrição é obrigatória")]
        [MinLength(3, ErrorMessage = "Descrição deve ter no mínimo 3 caracteres")]
        public string Descricao { get; set; }

        [Required(ErrorMessage = "Preço é obrigatório")]
        [Range(0.01, double.MaxValue, ErrorMessage = "Preço deve ser maior que zero")]
        public double Preco { get; set; }

        [Required(ErrorMessage = "Estoque é obrigatório")]
        [Range(0, int.MaxValue, ErrorMessage = "Estoque deve ser maior ou igual a zero")]
        public int Estoque { get; set; }

        [Required(ErrorMessage = "Código do produto é obrigatório")]
        [CodigoProdutoValidation(ErrorMessage = "O código deve estar no formato 'AAA-1234'")]
        public string CodigoProduto { get; set; }
    }
}
