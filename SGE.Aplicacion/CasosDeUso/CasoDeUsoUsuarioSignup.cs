namespace SGE.Aplicacion;

public class CasoDeUsoUsuarioSignup(IUsuarioRepositorio repoUser)
{
    public void Ejecutar(Usuario user)
    {
        repoUser.Signup(user);
    }
}
