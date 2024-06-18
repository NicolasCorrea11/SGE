namespace SGE.Aplicacion;

public class CasoDeUsoSignup(IUsuarioRepositorio repoUser)
{
    public void Ejecutar(Usuario user)
    {
        repoUser.AltaUsuario(user);
    }
}
