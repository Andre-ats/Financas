using Financas.Entity.Financas;

namespace Financas.Repository.GastoRepository;

public class EFCoreGastoRepository : IGastoRepository
{
    private DataBaseContext _dataBaseContext;

    public EFCoreGastoRepository(DataBaseContext dataBaseContext)
    {
        _dataBaseContext = dataBaseContext;
    }

    public bool CreateGasto(Gasto gasto)
    {
        try
        {
            _dataBaseContext.Add(gasto);
            _dataBaseContext.SaveChanges();
            return true;
        }
        catch (Exception e)
        {
            return false;
        }
    }
}