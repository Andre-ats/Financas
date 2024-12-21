using Financas.Repository.ReceitaRepository;
using Financas.Repository.UsuarioRepository;
using VinilProjeto.UseCase.UseCaseInterfaces;

namespace Financas.UseCase.ReceitaUseCase.CriarReceita;

public abstract class ICadastrarReceitaUseCase : IUseCase<CadastrarReceitaUseCaseInput, CadastrarReceitaUseCaseOutput>
{
    protected IReceitaRepository ReceitaRepository;
    protected IUsuarioRepository UsuarioRepository;

    public ICadastrarReceitaUseCase(IReceitaRepository receitaRepository, IUsuarioRepository usuarioRepository)
    {
        ReceitaRepository = receitaRepository;
        UsuarioRepository = usuarioRepository;
    }
}