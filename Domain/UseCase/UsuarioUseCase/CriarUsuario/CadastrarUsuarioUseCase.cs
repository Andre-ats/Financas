using Financas.Entity.Usuario;
using Financas.Factory.UsuarioFactory;
using Financas.Repository.UsuarioRepository;

namespace Financas.UseCase.UsuarioUseCase.CriarUsuario;

public class CadastrarUsuarioUseCase : ICadastrarUsuarioUseCase
{
    public CadastrarUsuarioUseCase(IUsuarioRepository repository) : base(repository)
    {
    }

    protected override CadastrarUsuarioUseCaseOutput executeService(CadastrarUsuarioUseCaseInput _useCaseInput)
    {
        try
        {
            Usuario usuario = new UsuarioFactory()
                .SetNome(_useCaseInput.Nome)
                .SetReceitaAtual(_useCaseInput.ReceitaAtual)
                .SetReceitaInicial(_useCaseInput.ReceitaInicial)
                .Build();

            _ = UsuarioRepository.CreateUsuario(usuario)
                ? true
                : throw new Exception("Nao foi possivel criar o usuario");

            return new CadastrarUsuarioUseCaseOutput()
            {
                resposta = $"Usuario {_useCaseInput.Nome} criado com sucesso!"
            };
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}