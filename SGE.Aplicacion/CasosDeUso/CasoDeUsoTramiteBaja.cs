namespace SGE.Aplicacion;

public class CasoDeUsoTramiteBaja(ITramiteRepositorio repoTramite, ServicioAutorizacionProvisiorio auth, ServicioActualizacionEstado act)
{
    public void Ejecutar(int id, int idUser)
    {
        if (!auth.PoseeElPermiso(idUser, Permiso.TramiteBaja))
        {
            throw new AutorizacionException("No se tienen los permisos necesarios");
        }
        else
        {
            int idExp = repoTramite.BajaTramite(id);
            act.ActualizarEstado(idExp);
        }

    }
}
