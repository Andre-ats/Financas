namespace Financas.Entity.Financas;

public class Receita : IEntity
{
    public string TituloReceita { get; protected set; } = String.Empty;
    public string? DescricaoReceita { get; protected set; }
    public string? Estabelecimento { get; protected set; }
    public long ReceitaDinheiro { get; protected set; }
    public DateTime DataReceita { get; protected set; }

    public static Receita CreateReceita(string tituloReceita, string descricaoReceita, string estabelecimento,
        long Receitadinheiro, DateTime dataReceita)
    {
        Receita Receita = new Receita()
        {
            Id = Guid.NewGuid(),
            TituloReceita = tituloReceita,
            DescricaoReceita = descricaoReceita,
            Estabelecimento = estabelecimento,
            ReceitaDinheiro = Receitadinheiro,
            DataReceita = dataReceita
        };
        return Receita;
    }
}