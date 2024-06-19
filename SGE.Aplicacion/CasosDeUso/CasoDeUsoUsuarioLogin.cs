namespace SGE.Aplicacion;

public class CasoDeUsoUsuarioLogin(IUsuarioRepositorio repoUser)
{
    public Usuario Ejecutar(string email, string contraseña)
    {
        Usuario? user = repoUser.Login(email, contraseña);
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
