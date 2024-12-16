using Financas.Entity.Usuario;

namespace Financas.Repository.UsuarioRepository;

public interface IUsuarioRepository
{
    public bool CreateUsuario(Usuario usuario);
}