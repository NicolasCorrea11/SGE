namespace SGE.Aplicacion;

public class ServicioAutorizacionProvisiorio: IServicioAutenticacion
{
    public bool PoseeElPermiso(int IdUsuario, Permiso permiso)
    {
        return IdUsuario == 1;
    }
}
