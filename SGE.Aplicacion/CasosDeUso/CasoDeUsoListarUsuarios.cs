namespace SGE.Aplicacion;

public class CasoDeUsoListarUsuarios(IUsuarioRepositorio urep)
{
    public List<Usuario> Ejecutar()
    {  
        return urep.ListarUsuarios();
    }
}
