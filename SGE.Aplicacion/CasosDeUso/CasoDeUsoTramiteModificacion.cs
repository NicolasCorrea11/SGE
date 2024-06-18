namespace SGE.Aplicacion;

public class CasoDeUsoTramiteModificacion(ITramiteRepositorio repoTram, IServicioAutorizacion auth)
{
  public void Ejecutar(Tramite t, Usuario user)
  {
    if (!auth.PoseeElPermiso(user, Permiso.TramiteModificacion))
    {
      throw new AutorizacionException();
    }
    else
    {
      repoTram.ModificacionTramite(t, user.Id);
    }
  }
}
