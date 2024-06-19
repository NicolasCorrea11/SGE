namespace SGE.Aplicacion;

public class CasoDeUsoUsuarioQuitarPermiso(IUsuarioRepositorio urep)
{
    public void Ejecutar(int id, Permiso p)
    {
        urep.QuitarPermiso(id, p);
    }
}
