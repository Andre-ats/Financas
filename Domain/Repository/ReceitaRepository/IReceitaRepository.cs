using Financas.Entity.Financas;

namespace Financas.Repository.ReceitaRepository;

public interface IReceitaRepository
{
    public bool CreateReceita(Receita receita);
}