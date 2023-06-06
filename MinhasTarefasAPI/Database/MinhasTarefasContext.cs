using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MinhasTarefasAPI.V1.Models;

namespace MinhasTarefasAPI.Database
{
    public class MinhasTarefasContext : IdentityDbContext<ApplicationUser>
    {
        public MinhasTarefasContext(DbContextOptions<MinhasTarefasContext> options) : base(options)
        {

        }
        public DbSet<Tarefa> Tarefas { get; set; }
        public DbSet<Token> Token { get; set; }
    }
}
