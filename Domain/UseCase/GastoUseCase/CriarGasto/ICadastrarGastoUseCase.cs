using Financas.Repository.GastoRepository;
using Financas.Repository.UsuarioRepository;
using VinilProjeto.UseCase.UseCaseInterfaces;

namespace Financas.UseCase.GastoUseCase.CriarGasto;

public abstract class ICadastrarGastoUseCase : IUseCase<CadastrarGastoUseCaseInput, CadastrarGastoUseCaseOutput> 
{
    protected IGastoRepository GastoRepository;
    protected IUsuarioRepository UsuarioRepository;

    public ICadastrarGastoUseCase(IGastoRepository receitaRepository, IUsuarioRepository usuarioRepository)
    {
        GastoRepository = receitaRepository;
        UsuarioRepository = usuarioRepository;
    }
}