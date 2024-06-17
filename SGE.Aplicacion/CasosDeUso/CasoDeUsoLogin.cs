namespace SGE.Aplicacion;

public class CasoDeUsoLogin(IUsuarioRepositorio urep)
{
    public Usuario Ejecutar(string email, string contraseña)
    {
        return urep.InicioSesion(email, contraseña);
    }
}
