namespace SGE.Aplicacion;

public class CasoDeUsoTramiteModificacion(ITramiteRepositorio repo, IServicioAutorizacion auth, IServicioActualizacionEstado act, RepositorioTramiteValidador validador)
{
  public void Ejecutar(Tramite t, int idUser)
  {
    if (!auth.PoseeElPermiso(idUser, Permiso.TramiteModificacion))
    {
      throw new AutorizacionException("No se tienen los permisos necesarios");
    }
    else
    {
      if (!validador.EsValido(t.Id, out string msg))
      {
        throw new RepositorioException(msg);
      }
      else
      {
        repo.ModificacionTramite(t, idUser);
        act.ActualizarEstado(t.ExpedienteId);
      }
    }
  }
}
