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
        var users =  _dataBaseContext.UsuarioDB.ToList();
        if (users.Count > 0)
        {
            throw new Exception("Ja possui usuario na base");
        }
        else
        {
            try
            {
                _dataBaseContext.UsuarioDB.Add(usuario);
                _dataBaseContext.SaveChanges();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao salvar no banco: " + ex.Message);
                throw;
            }
        }
    }

    public Usuario GetUsuario()
    {
        var usuario = _dataBaseContext.UsuarioDB.FirstOrDefault();
        if (usuario == null)
        {
            throw new Exception("Nenhum usuário encontrado.");
        }
        return usuario;
    }

    public void UpdateUsuario(Usuario usuario)
    {
        var usuarioExistente = _dataBaseContext.UsuarioDB.Find(usuario.Id);
        if (usuarioExistente == null)
        {
            throw new Exception("Usuário não encontrado.");
        }

        _dataBaseContext.UsuarioDB.Update(usuario);
        _dataBaseContext.SaveChanges();
    }
}