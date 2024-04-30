namespace SGE.Aplicacion;

public interface IServicioAutorizacion
{
    public bool PoseeElPermiso(int idUser, Permiso p);
}
