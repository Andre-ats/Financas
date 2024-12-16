using Financas.Entity.Usuario;

namespace Financas.Factory.UsuarioFactory;

public class UsuarioFactory
{
    private string _Nome { get; set; } = String.Empty;
    private long _ReceitaInicial { get; set; }
    private long _ReceitaAtual { get; set; }
    private DateTime _DataDeCadastro { get; set; }

    private void init()
    {
        _Nome = "";
        _ReceitaInicial = 0;
        _ReceitaAtual = 0;
        _DataDeCadastro = new DateTime();
    }

    public UsuarioFactory SetNome(string nome)
    {
        this._Nome = nome;
        return this;
    }
    
    public UsuarioFactory SetReceitaInicial(long receitainicial)
    {
        this._ReceitaInicial = receitainicial;
        return this;
    }
    
    public UsuarioFactory SetReceitaAtual(long receitaatual)
    {
        this._ReceitaAtual = receitaatual;
        return this;
    }

    public bool Validar()
    {
        _ = _Nome == null ? throw new Exception("Nome nao pode ser nulo") : true;

        return true;
    }

    public Usuario Build()
    {
        _ = this.Validar() ? true : throw new Exception("Nao passou nas validacoes");

        Usuario usuario = Usuario.CreateUsuario(
            _Nome,
            _ReceitaInicial,
            _ReceitaAtual,
            DateTime.Now
        );
        
        this.init();

        return usuario;

    }
    
}