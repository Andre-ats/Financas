using Financas.Entity.Usuario;

namespace Financas.Repository.UsuarioRepository;

public class EFCoreUsuarioRepository : IUsuarioRepository
{
    private DataBaseContext _dataBaseContext;

    public bool CreateUsuario(Usuario usuario)
    {
        _dataBaseContext.UsuarioDB.Add(usuario);
        return _dataBaseContext.SaveChanges() > 0;
    }
}