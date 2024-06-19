namespace SGE.Aplicacion;

public class CasoDeUsoUsuarioModificacion(IUsuarioRepositorio repoUser)
{
    public void Ejecutar(Usuario user)
    {
        repoUser.ModificarUsuario(user);
    }
}
