using System.ComponentModel.DataAnnotations;

namespace ValidacaoCustomizada
{
    public class Usuario4
    {
        [Required(ErrorMessage = "O campo 'Nome' é de preenchimento obrigatório.")]
        public string Nome { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required, StringLength(10, MinimumLength = 6)]
        [MinhaValidacao(ErrorMessage = "O campo senha deve possuir 10 caracteres")]
        public string Senha { get; set; }
    }
}
