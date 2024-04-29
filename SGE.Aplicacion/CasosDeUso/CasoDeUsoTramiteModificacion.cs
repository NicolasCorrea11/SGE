namespace SGE.Aplicacion;

public class CasoDeUsoTramiteModificacion(ITramiteRepositorio repoTramite, ServicioAutorizacionProvisiorio auth, ServicioActualizacionEstado act)
{
  public void Ejecutar(Tramite tramite, int IdUser)
  {
    if (!auth.PoseeElPermiso(IdUser, Permiso.TramiteModificacion))
    {
      throw new AutorizacionException("No se tienen los permisos necesarios");
    }
    else
    {
      repoTramite.ModificacionTramite(tramite, IdUser);
      act.ActualizarEstado(tramite.ExpedienteId);
    }
  }
}
