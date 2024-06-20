namespace SGE.Aplicacion;

public class CasoDeUsoUsuarioLogin(IUsuarioRepositorio repoUser, IServicioHash hash)
{
    public Usuario Ejecutar(string email, string contraseña)
    {
        string pw = hash.HashingPass(contraseña);
        Usuario? user = repoUser.Login(email, pw);
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
