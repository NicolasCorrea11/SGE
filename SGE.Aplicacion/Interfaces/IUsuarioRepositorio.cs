namespace SGE.Aplicacion;

public interface IUsuarioRepositorio
{
    public void AltaUsuario(Usuario u);
    public Usuario? InicioSesion(string email, string contraseña);
    public void ModificarUsuario(Usuario u);
    public Usuario? ConsultaPorId(int id);
    public void OtorgarPermiso(int id, Permiso p);
    public void QuitarPermiso(int id, Permiso p);
}
