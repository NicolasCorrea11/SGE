namespace SGE.Aplicacion;

public interface IServicioAutorizacion
{
    public bool PoseeElPermiso(int IdUsuario, Permiso permiso);
}
