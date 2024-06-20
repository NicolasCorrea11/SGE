namespace SGE.Aplicacion;

public class CasoDeUsoUsuarioModificacion(IUsuarioRepositorio repoUser, IServicioHash hashing)
{
    public void Ejecutar(Usuario user)
    {
        user.Contraseña = hashing.GetHash(user.Contraseña);
        repoUser.ModificarUsuario(user);
    }
}
