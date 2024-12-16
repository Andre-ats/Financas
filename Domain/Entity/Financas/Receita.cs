namespace Financas.Entity.Financas;

public class Receita : IEntity
{
    public string TituloReceita { get; protected set; } = String.Empty;
    public string? DescricaoReceita { get; protected set; }
    public string? Estabelecimento { get; protected set; }
    public long ReceitaDinheiro { get; protected set; }
    public DateTime DataReceita { get; protected set; }

    public static Receita CreateReceita(string tituloreceita, string descricaoreceita, string estabelecimento,
        long receitadinheiro, DateTime dataReceita)
    {
        Receita receita = new Receita()
        {
            Id = Guid.NewGuid(),
            TituloReceita = tituloreceita,
            DescricaoReceita = descricaoreceita,
            Estabelecimento = estabelecimento,
            ReceitaDinheiro = receitadinheiro,
            DataReceita = dataReceita
        };
        return receita;
    }
}