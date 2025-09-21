using System.ComponentModel.DataAnnotations;

namespace WebApp.Models
{
    public class Aluno
    {
        [Required(ErrorMessage = "Nome é obrigatório")]
        [MinLength(3, ErrorMessage = "Nome deve ter no mínimo 3 caracteres")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "RA é obrigatório")]
        [RaValidation(ErrorMessage = "RA deve começar com 'RA' seguido de 6 dígitos numéricos")]
        public string Ra { get; set; }

        [Required(ErrorMessage = "Email é obrigatório")]
        [EmailAddress(ErrorMessage = "Email inválido")]
        public string Email { get; set; }

        [Required(ErrorMessage = "CPF é obrigatório")]
        [RegularExpression(@"^\d{11}$", ErrorMessage = "CPF deve conter exatamente 11 dígitos numéricos")]
        public string Cpf { get; set; }

        public bool Ativo { get; set; }
    }
}
