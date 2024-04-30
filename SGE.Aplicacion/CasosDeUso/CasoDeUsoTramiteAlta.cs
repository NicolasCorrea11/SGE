namespace SGE.Aplicacion;

public class CasoDeUsoTramiteAlta(ITramiteRepositorio repoTramite, IServicioAutorizacion auth, IServicioActualizacionEstado act, TramiteValidador validador)
{
  public void Ejecutar(Tramite t, int idUser)
  {
    if (!auth.PoseeElPermiso(idUser, Permiso.TramiteAlta))
    {
      throw new AutorizacionException("No se tienen los permisos necesarios");
    }
    else
    {
      t.IdUser = idUser;
      if (!validador.esValido(t, out string mensajeError))
      {
        throw new ValidacionException(mensajeError);
      }
      else
      {
        t.FechayHoraCr = DateTime.Now;
        t.FechayHoraMod = DateTime.Now;
        repoTramite.AltaTramite(t);
        act.ActualizarEstado(t.ExpedienteId);
      }
    }
  }
}
