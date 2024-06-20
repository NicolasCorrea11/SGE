namespace SGE.Aplicacion;

public class CasoDeUsoUsuarioModificacion(IUsuarioRepositorio repoUser, IServicioHash hashing, UsuarioValidador validador)
{
    public void Ejecutar(Usuario user)
    {
        if (!validador.EsValido(user, out string msg))
        {
            throw new ValidacionException(msg);
        }
        else 
        {
            user.Contraseña = hashing.GetHash(user.Contraseña);
            repoUser.ModificarUsuario(user);
        }
    }
}
