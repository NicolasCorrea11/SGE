namespace SGE.Aplicacion;

public class ServicioAutorizacionProvisiorio: IServicioAutorizacion
{
    public bool PoseeElPermiso(int IdUsuario, Permiso permiso)
    {
        return IdUsuario == 1;
    }
}
