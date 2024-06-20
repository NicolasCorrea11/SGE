namespace SGE.Aplicacion;

public class CasoDeUsoUsuarioOtorgarPermiso(IUsuarioRepositorio repoUser)
{
    public void Ejecutar(int id, Permiso p)
    {
        repoUser.OtorgarPermiso(id, p);
    }
}
