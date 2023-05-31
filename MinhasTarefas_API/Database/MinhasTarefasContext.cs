using Microsoft.EntityFrameworkCore;
using MinhasTarefas_API.Models;

namespace MinhasTarefas_API.Database
{
    public class MinhasTarefasContext : DbContext
    {
        public MinhasTarefasContext(DbContextOptions<MinhasTarefasContext> options) : base(options)
        {

        }

        public DbSet<Tarefa> Tarefas { get; set; }
    }
}
