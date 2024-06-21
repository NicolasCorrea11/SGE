namespace SGE.Aplicacion;

public class UsuarioLogeado
{
    public Usuario User { get; set; } = new();

    public void SetUser(Usuario user)
    {
        User = user;
    }

    public void CerrarSesion()
    {
        User = new Usuario();
    }
}
