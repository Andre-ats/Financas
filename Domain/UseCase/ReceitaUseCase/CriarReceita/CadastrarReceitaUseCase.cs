using Financas.Entity.Financas;
using Financas.Entity.Usuario;
using Financas.Factory.FinancasFactory;
using Financas.Factory.UsuarioFactory;
using Financas.Repository.ReceitaRepository;
using Financas.Repository.UsuarioRepository;

namespace Financas.UseCase.ReceitaUseCase.CriarReceita;

public class CadastrarReceitaUseCase : ICadastrarReceitaUseCase
{
    public CadastrarReceitaUseCase(IReceitaRepository receitaRepository, IUsuarioRepository usuarioRepository) : base(receitaRepository, usuarioRepository)
    {
    }

    protected override CadastrarReceitaUseCaseOutput executeService(CadastrarReceitaUseCaseInput _useCaseInput)
    {
        try
        {
            Receita receita = new ReceitaFactory()
                .SetTituloReceita(_useCaseInput.TituloReceita!)
                .SetDescricaoReceita(_useCaseInput.DescricaoReceita!)
                .SetEstabelecimento(_useCaseInput.Estabelecimento!)
                .SetReceitaDinheiro(_useCaseInput.ReceitaDinheiro)
                .SetDataCadastro(_useCaseInput.DataReceita)
                .Build();
            
            var receitaCriada = ReceitaRepository.CreateReceita(receita);

            if (receitaCriada)
            {
                Usuario usuario = UsuarioRepository.GetUsuario();
                usuario.UpdateReceitaAtual(_useCaseInput.ReceitaDinheiro + usuario.ReceitaAtual);
                UsuarioRepository.UpdateUsuario(usuario);
            }
            else
            {
                throw new Exception("Erro ao salvar");
            }

            return new CadastrarReceitaUseCaseOutput()
            {
                resposta = "Receita criada com sucesso!"
            };
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }

}