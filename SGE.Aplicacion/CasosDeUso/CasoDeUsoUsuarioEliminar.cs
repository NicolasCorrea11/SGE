namespace SGE.Aplicacion;

public class CasoDeUsoUsuarioEliminar(IUsuarioRepositorio repoUser)
{
    public void Ejecutar(int id)
    {
        repoUser.EliminarUsuario(id);
    }
}
