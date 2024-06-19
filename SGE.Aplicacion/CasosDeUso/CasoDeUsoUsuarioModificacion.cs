namespace SGE.Aplicacion;

public class CasoDeUsoUsuarioModificacion(IUsuarioRepositorio urep)
{
    public void Ejecutar(Usuario user, Usuario u)
    {
        if (user.Id == u.Id || u.Id == 1)
        {
            urep.ModificarUsuario(user);
        }
        else
        {
            throw new AutorizacionException();
        }
        
    }
}
