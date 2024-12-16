namespace Financas.Entity.Usuario;

public class Usuario : IEntity
{
    public string Nome { get; protected set; } = String.Empty;
    public long ReceitaInicial { get; protected set; }
    public long ReceitaAtual { get; protected set; }
    public DateTime DataDeCadastro { get; protected set; }
    
    private Usuario(){}

    public static Usuario CreateUsuario(string nome, long receitainicial, long receitaatual, DateTime dataCriacao)
    {
        Usuario usuario = new Usuario()
        {
            Id = Guid.NewGuid(),
            Nome = nome,
            ReceitaInicial = receitainicial,
            ReceitaAtual = receitainicial,
            DataDeCadastro = dataCriacao
        };
        return usuario;
    }
}