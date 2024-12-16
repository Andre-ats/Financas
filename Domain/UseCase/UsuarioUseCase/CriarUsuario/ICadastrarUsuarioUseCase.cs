using Financas.Repository.UsuarioRepository;
using VinilProjeto.UseCase.UseCaseInterfaces;

namespace Financas.UseCase.UsuarioUseCase.CriarUsuario;

public abstract class ICadastrarUsuarioUseCase : IUseCase<CadastrarUsuarioUseCaseInput, CadastrarUsuarioUseCaseOutput>
{
    protected IUsuarioRepository UsuarioRepository;

    public ICadastrarUsuarioUseCase(IUsuarioRepository repository)
    {
        UsuarioRepository = repository;
    }
}