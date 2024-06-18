namespace SGE.Aplicacion;

public class CasoDeUsoTramiteAlta(ITramiteRepositorio repoTram, IServicioAutorizacion auth, TramiteValidador validador)
{
  public void Ejecutar(Tramite t, Usuario user)
  {
    if (!auth.PoseeElPermiso(user, Permiso.TramiteAlta))
    {
      throw new AutorizacionException();
    }
    else
    {
      if (!validador.EsValido(t, out string msg))
      {
        throw new ValidacionException(msg);
      }
      else
      {
        t.FechayHoraCr = DateTime.Now;
        t.FechayHoraMod = DateTime.Now;
        t.IdUser = user.Id;
        repoTram.AltaTramite(t);
      }
    }
  }
}
