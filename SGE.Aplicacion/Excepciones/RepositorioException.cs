namespace SGE.Aplicacion;

public class RepositorioException: Exception
{
    public RepositorioException(string msg): base(msg) {}
    //"La entidad que se intenta eliminar, modificar o acceder no existe en el repositorio";
}
