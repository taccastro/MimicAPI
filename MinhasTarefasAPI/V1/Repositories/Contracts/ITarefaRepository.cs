using MinhasTarefasAPI.V1.Models;
using System;
using System.Collections.Generic;

namespace MinhasTarefasAPI.V1.Repositories.Contracts
{
    public interface ITarefaRepository
    {
        List<Tarefa> Sincronizacao(List<Tarefa> tarefas);
        List<Tarefa> Restauracao(ApplicationUser usuario, DateTime dataUltimaSincronizacao);
        object Sincronizacao(Tarefa tarefas);
    }
}
