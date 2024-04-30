namespace SGE.Aplicacion;

public class ServicioAutorizacionProvisiorio: IServicioAutorizacion
{
    public bool PoseeElPermiso(int idUser, Permiso p)
    {
        return idUser == 1;
    }
}
