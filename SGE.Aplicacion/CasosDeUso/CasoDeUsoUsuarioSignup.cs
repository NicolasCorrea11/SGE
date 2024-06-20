namespace SGE.Aplicacion;

public class CasoDeUsoUsuarioSignup(IUsuarioRepositorio repoUser, IServicioHash hash)
{
    public void Ejecutar(Usuario user)
    {
        string pw = hash.HashingPass(user.Contraseña);
        user.Contraseña = pw;
        repoUser.Signup(user);
    }
}
