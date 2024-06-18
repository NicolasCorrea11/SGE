namespace SGE.Aplicacion;

public class CasoDeUsoLogin(IUsuarioRepositorio urep)
{
    public Usuario Ejecutar(string email, string contraseña)
    {
        Usuario? user = urep.InicioSesion(email, contraseña);
        if (user != null)
        {
            return user;
        }
        else{
            throw new UsuarioException("Usuario no existe");
        }
    }
}
