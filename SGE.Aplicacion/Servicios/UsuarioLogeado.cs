namespace SGE.Aplicacion;

public class UsuarioLogeado
{
    public Usuario user {get; set;} = new();

    public void setUser(Usuario user)
    {
        this.user = user;
    }

    public void CerrarSesion()
    {
        this.user = new Usuario();
    }
}
