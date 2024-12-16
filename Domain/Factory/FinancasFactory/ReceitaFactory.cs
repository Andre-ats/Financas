using Financas.Entity.Financas;

namespace Financas.Factory.FinancasFactory;

public class ReceitaFactory
{
    private string _TituloReceita { get; set; }
    private string _DescricaoReceita { get; set; }
    private string _Estabelecimento { get; set; }
    private long _ReceitaDinheiro { get; set; }
    public DateTime _DataReceita { get; protected set; }

    private void Init()
    {
        _TituloReceita = "";
        _DescricaoReceita = "";
        _Estabelecimento = "";
        _ReceitaDinheiro = 0;
        _DataReceita = new DateTime();
    }

    public ReceitaFactory SetTituloReceita(string tituloreceita)
    {
        this._TituloReceita = tituloreceita;
        return this;
    }
    
    public ReceitaFactory SetDescricaoReceita(string descricaoreceita)
    {
        this._DescricaoReceita = descricaoreceita;
        return this;
    }
    
    public ReceitaFactory SetEstabelecimento(string estabelecimento)
    {
        this._Estabelecimento = estabelecimento;
        return this;
    }
    
    public ReceitaFactory SetReceitaDinheiro(long receitadinheiro)
    {
        this._ReceitaDinheiro = receitadinheiro;
        return this;
    }
    
    public ReceitaFactory SetDataCadastro(DateTime datacadastro)
    {
        this._DataReceita = datacadastro;
        return this;
    }

    public bool Validar()
    {
        _ = _TituloReceita == null ? throw new Exception("Nome nao pode ser nulo") : true;
        _ = _ReceitaDinheiro == 0 ? throw new Exception("Receita nao pode ser 0") : true;

        return true;
    }

    public Receita Build()
    {
        _ = this.Validar() ? true : throw new Exception("Nao passou nas validacoes");

        Receita receita = Receita.CreateReceita(
            _TituloReceita,
            _DescricaoReceita,
            _Estabelecimento,
            _ReceitaDinheiro,
            _DataReceita
        );
        
        this.Init();

        return receita;

    }
}