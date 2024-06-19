namespace SGE.Aplicacion;

public class CasoDeUsoLogin(IUsuarioRepositorio repoUser)
{
    public Usuario Ejecutar(string email, string contraseña)
    {
        Usuario? user = repoUser.InicioSesion(email, contraseña);
        if (user == null)
        {
            throw new UsuarioException("Usuario no existe");
        }
        else
        {
            return user;
        }
    }
}
