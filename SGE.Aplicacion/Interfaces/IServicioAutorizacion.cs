namespace SGE.Aplicacion;

public interface IServicioAutenticacion
{
    public bool PoseeElPermiso(int IdUsuario, Permiso permiso);
}
