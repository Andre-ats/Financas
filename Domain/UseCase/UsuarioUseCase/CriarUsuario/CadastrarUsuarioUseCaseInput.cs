using VinilProjeto.UseCase.UseCaseInterfaces;

namespace Financas.UseCase.UsuarioUseCase.CriarUsuario;

public class CadastrarUsuarioUseCaseInput : IUseCaseInput
{
    public string? Nome;
    public long ReceitaInicial;
    public long ReceitaAtual;
}