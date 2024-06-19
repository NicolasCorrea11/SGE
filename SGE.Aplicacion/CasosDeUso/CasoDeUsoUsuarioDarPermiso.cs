namespace SGE.Aplicacion;

public class CasoDeUsoUsuarioDarPermiso(IUsuarioRepositorio urep)
{
    public void Ejecutar(int id, Permiso p)
    {
        urep.OtorgarPermiso(id, p);
    }
}
