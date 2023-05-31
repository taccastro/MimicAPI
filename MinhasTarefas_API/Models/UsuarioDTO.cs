using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MinhasTarefas_API.Models
{
    public class UsuarioDTO
    {

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

        [ForeignKey("Usuario")]        
        public string UsuarioId { get; set; }

        public virtual ApplicationUser Usuario { get; set; }

    }
}
