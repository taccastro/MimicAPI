using MinhasTarefasAPI.V1.Models;

namespace MinhasTarefasAPI.V1.Repositories.Contracts
{
    public interface IUsuarioRepository
    {
        void Cadastrar(ApplicationUser usuario, string senha);
        ApplicationUser Obter(string email, string senha);
        ApplicationUser Obter(string id);
    }
}
