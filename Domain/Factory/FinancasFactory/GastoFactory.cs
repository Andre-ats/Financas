using Financas.Entity.Financas;

namespace Financas.Factory.FinancasFactory;

public class GastoFactory
{
    private string _TituloGasto { get; set; }
    private string _DescricaoGasto { get; set; }
    private string _Estabelecimento { get; set; }
    private long _GastoDinheiro { get; set; }
    public DateTime _DataGasto { get; protected set; }

    private void Init()
    {
        _TituloGasto = "";
        _DescricaoGasto = "";
        _Estabelecimento = "";
        _GastoDinheiro = 0;
        _DataGasto = new DateTime();
    }

    public GastoFactory SetTituloGasto(string titulogasto)
    {
        this._TituloGasto = titulogasto;
        return this;
    }
    
    public GastoFactory SetDescricaoGasto(string descricaogasto)
    {
        this._DescricaoGasto = descricaogasto;
        return this;
    }
    
    public GastoFactory SetEstabelecimento(string estabelecimento)
    {
        this._Estabelecimento = estabelecimento;
        return this;
    }
    
    public GastoFactory SetGastoDinheiro(long gastodinheiro)
    {
        this._GastoDinheiro = gastodinheiro;
        return this;
    }
    
    public GastoFactory SetDataCadastro(DateTime datacadastro)
    {
        this._DataGasto = datacadastro;
        return this;
    }

    public bool Validar()
    {
        _ = _TituloGasto == null ? throw new Exception("Nome nao pode ser nulo") : true;
        _ = _GastoDinheiro == 0 ? throw new Exception("Gasto nao pode ser 0") : true;

        return true;
    }

    public Gasto Build()
    {
        _ = this.Validar() ? true : throw new Exception("Nao passou nas validacoes");

        Gasto gasto = Gasto.CreateGasto(
            _TituloGasto,
            _DescricaoGasto,
            _Estabelecimento,
            _GastoDinheiro,
            _DataGasto
        );
        
        this.Init();

        return gasto;

    }
}