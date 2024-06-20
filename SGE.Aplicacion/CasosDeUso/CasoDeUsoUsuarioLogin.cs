namespace SGE.Aplicacion;

public class CasoDeUsoUsuarioLogin(IUsuarioRepositorio repoUser, IServicioHash hashing)
{
    public Usuario Ejecutar(string email, string pass)
    {
        string hash = hashing.GetHash(pass);
        Usuario? user = repoUser.Login(email, hash);
        if (user == null)
        {
            throw new UsuarioException("El usuario no existe");
        }
        else
        {
            return user;
        }
    }
}
