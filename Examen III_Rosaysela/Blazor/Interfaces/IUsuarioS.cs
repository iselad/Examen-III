using Modelos;

namespace Blazor.Interfaces;

public interface IUsuarioS
{
    
    Task<IEnumerable<Usuario>> GetLista();
    Task<Usuario> GetPorCodigo(string codigo);
}
