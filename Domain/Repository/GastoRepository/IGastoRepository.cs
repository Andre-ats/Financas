using Financas.Entity.Financas;

namespace Financas.Repository.GastoRepository;

public interface IGastoRepository
{
    public bool CreateGasto(Gasto gasto);
}