using Financas.Entity.Usuario;

namespace Financas.Repository.UsuarioRepository;

public interface IUsuarioRepository
{
    public void CreateUsuario(Usuario usuario);
}