using Blazor.Data;
using Blazor.Interfaces;
using Datos.Interfaces;
using Datos.Repositorios;
using Modelos;

namespace Blazor.Servicios;

public class UsuarioS : IUsuarioS
{
    private readonly MySQLConfiguration _configuration;
    private IUsuarioR usuarioRepositorio;

    public UsuarioS(MySQLConfiguration configuration)
    {
        _configuration = configuration;
        usuarioRepositorio = new RUsuario(configuration.CadenaConexion);
    }

    

   
    public async Task<IEnumerable<Usuario>> GetLista()
    {
        return await usuarioRepositorio.GetLista();
    }

    public async Task<Usuario> GetPorCodigo(string codigo)
    {
        return await usuarioRepositorio.GetPorCodigo(codigo);
    }

    public Task<bool> Nuevo(Usuario usuario)
    {
        throw new NotImplementedException();
    }
}
