namespace SGE.Aplicacion;

public class RepositorioExeption: Exception
{
    public RepositorioExeption(string msg) : base(msg) {}
    //"La entidad que se intenta eliminar, modificar o acceder no existe en el repositorio";
}
