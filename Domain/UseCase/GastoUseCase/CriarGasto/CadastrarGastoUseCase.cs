using Financas.Entity.Financas;
using Financas.Entity.Usuario;
using Financas.Factory.FinancasFactory;
using Financas.Repository.GastoRepository;
using Financas.Repository.UsuarioRepository;

namespace Financas.UseCase.GastoUseCase.CriarGasto;

public class CadastrarGastoUseCase : ICadastrarGastoUseCase
{
    public CadastrarGastoUseCase(IGastoRepository receitaRepository, IUsuarioRepository usuarioRepository) : base(receitaRepository, usuarioRepository)
    {
    }

    protected override CadastrarGastoUseCaseOutput executeService(CadastrarGastoUseCaseInput _useCaseInput)
    {
        try
        {
            Gasto receita = new GastoFactory()
                .SetTituloGasto(_useCaseInput.TituloGasto!)
                .SetDescricaoGasto(_useCaseInput.DescricaoGasto!)
                .SetEstabelecimento(_useCaseInput.Estabelecimento!)
                .SetGastoDinheiro(_useCaseInput.GastoDinheiro)
                .SetDataCadastro(_useCaseInput.DataGasto)
                .Build();
            
            var receitaCriada = GastoRepository.CreateGasto(receita);

            if (receitaCriada)
            {
                Usuario usuario = UsuarioRepository.GetUsuario();
                usuario.UpdateReceitaAtual(usuario.ReceitaAtual + receita.GastoDinheiro);
                UsuarioRepository.UpdateUsuario(usuario);
            }
            else
            {
                throw new Exception("Erro ao salvar");
            }

            return new CadastrarGastoUseCaseOutput()
            {
                resposta = "Gasto criada com sucesso!"
            };
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}