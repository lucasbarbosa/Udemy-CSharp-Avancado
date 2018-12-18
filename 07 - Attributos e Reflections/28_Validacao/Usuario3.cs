using System.ComponentModel.DataAnnotations;

namespace Validacao
{
    public class Usuario3
    {
        [Required(ErrorMessage = "O campo 'Nome' é de preenchimento obrigatório.")]
        public string Nome { get; set; }

        [Required(ErrorMessageResourceType = typeof(Idiomas.Linguagem), ErrorMessageResourceName = "msg_obrigatorio")]
        [EmailAddress]
        public string Email { get; set; }

        [Required, StringLength(10, MinimumLength = 6)]
        public string Senha { get; set; }
    }
}
