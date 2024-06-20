namespace SGE.Aplicacion;

public class CasoDeUsoUsuarioSignup(IUsuarioRepositorio repoUser, IServicioHash hashing)
{
    public void Ejecutar(Usuario user)
    {
        user.Contraseña = hashing.GetHash(user.Contraseña);
        repoUser.Signup(user);
    }
}
