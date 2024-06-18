namespace SGE.Aplicacion;

public class ServicioAutorizacion: IServicioAutorizacion
{
    public bool PoseeElPermiso(Usuario user, Permiso p)
    {
        if (user.Id == 1)
        {
            return true;
        }
        else 
        {
            return user.Permisos[(int)p] == true;
        }
    }
}
