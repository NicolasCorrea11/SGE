namespace SGE.Aplicacion;

public interface IUsuarioRepositorio
{
    public void AltaUsuario(Usuario u);
    public Usuario InicioSesion(string email, string contraseña);

}
