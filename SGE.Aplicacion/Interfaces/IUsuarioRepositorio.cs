namespace SGE.Aplicacion;

public interface IUsuarioRepositorio
{
    public void Signup(Usuario u);
    public Usuario? Login(string email, string contraseña);
    public void ModificarUsuario(Usuario u);
    public Usuario? ConsultaPorId(int id);
    public List<Usuario> ListarUsuarios();
    public void OtorgarPermiso(int id, Permiso p);
    public void QuitarPermiso(int id, Permiso p);
}
