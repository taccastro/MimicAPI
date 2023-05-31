using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;

namespace MinhasTarefas_API.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string FullName { get; set; }

        [ForeignKey("UsuarioId")]
        public virtual ICollection<Tarefa> Tarefas { get; set; }
    }
}
