namespace SGE.Aplicacion;

public class CasoDeUsoLogin(IUsuarioRepositorio repoUser)
{
    public Usuario? Ejecutar(string email, string contraseña)
    {
        return repoUser.InicioSesion(email, contraseña);
    }
}
