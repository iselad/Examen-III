using Modelos;

namespace Datos.Interfaces;

public interface IUsuarioR
{
  
 
    Task<IEnumerable<Usuario>> GetLista();
    Task<Usuario> GetPorCodigo(string codigo);
    Task<bool> ValidaUsuario(Login login);
}
