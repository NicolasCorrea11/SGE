namespace SGE.Aplicacion;

public interface IServicioAutorizacion
{
    public bool PoseeElPermiso(Usuario user, Permiso p);
}
