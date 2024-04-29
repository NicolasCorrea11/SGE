namespace SGE.Aplicacion;

public class CasoDeUsoTramiteAlta(ITramiteRepositorio repo)
{
  public void Ejecutar(Tramite t, int idUser)
  {
    ServicioAutorizacionProvisiorio val = new();
    if (val.PoseeElPermiso(idUser, Permiso.TramiteAlta))
    {
      string mensajeError;
      TramiteValidador valid = new();
      if (valid.esValido(t, out mensajeError))
      {
        t.FechayHoraCr = DateTime.Now;
        t.FechayHoraMod = DateTime.Now;
        repo.AltaTramite(t, idUser);
      }
      else
      {
        throw new ValidacionException(mensajeError);
      }
    }
    else
    {
      throw new AutorizacionException("No se tienen los permisos necesarios");
    }
  }
}
