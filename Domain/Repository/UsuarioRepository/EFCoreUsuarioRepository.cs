using Financas.Entity.Usuario;

namespace Financas.Repository.UsuarioRepository;

public class EFCoreUsuarioRepository : IUsuarioRepository
{
    private DataBaseContext _dataBaseContext;

    public EFCoreUsuarioRepository(DataBaseContext dataBaseContext)
    {
        _dataBaseContext = dataBaseContext;
    }

    public void CreateUsuario(Usuario usuario)
    {
        foreach (var property in typeof(Usuario).GetProperties())
        {
            var value = property.GetValue(usuario);
            Console.WriteLine($"{property.Name}: {value}");
        }


        _dataBaseContext.UsuarioDB.Add(usuario);
    
        try
        {
            _dataBaseContext.SaveChanges();
        }
        catch (Exception ex)
        {
            Console.WriteLine("Erro ao salvar no banco: " + ex.Message);
            throw;
        }
    }
}