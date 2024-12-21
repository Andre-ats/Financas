using Financas.Entity.Financas;
using Financas.Entity.Usuario;
using Financas.Repository.UsuarioRepository;

namespace Financas.Repository.ReceitaRepository;

public class EFCoreReceitaRepository : IReceitaRepository
{
    private DataBaseContext _dataBaseContext;

    public EFCoreReceitaRepository(DataBaseContext dataBaseContext)
    {
        _dataBaseContext = dataBaseContext;
    }

    public bool CreateReceita(Receita receita)
    {
        try
        {
            _dataBaseContext.Add(receita);
            _dataBaseContext.SaveChanges();
            return true;
        }
        catch (Exception e)
        {
            return false;
        }
    }
}