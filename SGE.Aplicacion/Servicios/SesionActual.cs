namespace SGE.Aplicacion;

public class SesionActual
{
    public Usuario User { get; set; } = new();

    public void CerrarSesion()
    {
        User = new Usuario();
    }
}
