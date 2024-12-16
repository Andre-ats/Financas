using VinilProjeto.UseCase.UseCaseInterfaces;

namespace Financas.UseCase.UsuarioUseCase.CriarUsuario;

public class CadastrarUsuarioUseCaseInput : IUseCaseInput
{
    public string Nome { get; set; }
    public long ReceitaInicial { get; set; }
}