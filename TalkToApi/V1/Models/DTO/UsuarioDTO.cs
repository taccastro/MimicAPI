using System.ComponentModel.DataAnnotations;

namespace TalkToApi.V1.Models.DTO
{
    public class UsuarioDTO : BaseDTO
    {
        public string Id { get; set; }
        [Required]
        public string Nome { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        public string Senha { get; set; }
        [Required]
        [Compare("Senha")]
        public string ConfirmacaoSenha { get; set; }
        public string Slogan { get; set; }
    }
}
