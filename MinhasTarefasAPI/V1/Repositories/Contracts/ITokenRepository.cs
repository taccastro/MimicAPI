using MinhasTarefasAPI.V1.Models;

namespace MinhasTarefasAPI.V1.Repositories.Contracts
{
    public interface ITokenRepository
    {
        //C - R - U.
        void Cadastrar(Token token);
        //Key-Value
        Token Obter(string refreshToken);
        void Atualizar(Token token);
    }
}
