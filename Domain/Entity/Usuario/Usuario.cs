namespace Financas.Entity.Usuario;

public class Usuario : IEntity
{
    public string Nome { get; protected set; }
    public long ReceitaInicial { get; protected set; }
    public long ReceitaAtual { get; protected set; }
    public DateTimeOffset DataDeCadastro { get; protected set; }
    
    public long UpdateReceitaAtual(long novaReceita)
    {
        ReceitaAtual = novaReceita;
        return ReceitaAtual;
    }
    
    private Usuario(){}

    public static Usuario CreateUsuario(string nome, long receitainicial, long receitaatual, DateTimeOffset dataCriacao)
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