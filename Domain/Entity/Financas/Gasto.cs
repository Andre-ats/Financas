namespace Financas.Entity.Financas;

public class Gasto : IEntity
{
    public string TituloGasto { get; protected set; } = String.Empty;
    public string? DescricaoGasto { get; protected set; }
    public string? Estabelecimento { get; protected set; }
    public long GastoDinheiro { get; protected set; }
    public DateTime DataGasto { get; protected set; }

    public static Gasto CreateGasto(string titulogasto, string descricaogasto, string estabelecimento,
        long gastodinheiro, DateTime datagasto)
    {
        Gasto gasto = new Gasto()
        {
            Id = Guid.NewGuid(),
            TituloGasto = titulogasto,
            DescricaoGasto = descricaogasto,
            Estabelecimento = estabelecimento,
            GastoDinheiro = gastodinheiro,
            DataGasto = datagasto
        };
        return gasto;
    }
}