namespace SGE.Aplicacion;

public class CasoDeUsoTramiteAlta(ITramiteRepositorio repoTramite, ServicioAutorizacionProvisiorio auth, ServicioActualizacionEstado act)
{
  public void Ejecutar(Tramite t, int idUser)
  {
    if (!auth.PoseeElPermiso(idUser, Permiso.TramiteAlta))
    {
      throw new AutorizacionException("No se tienen los permisos necesarios");
    }
    else
    { 
      t.FechayHoraCr = DateTime.Now;
      t.FechayHoraMod = DateTime.Now;
      repoTramite.AltaTramite(t, idUser);
      act.ActualizarEstado(t.ExpedienteId);
    }
  }
}
