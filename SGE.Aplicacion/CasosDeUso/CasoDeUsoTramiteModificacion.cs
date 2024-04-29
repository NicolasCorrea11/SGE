namespace SGE.Aplicacion;

public class CasoDeUsoTramiteModificacion(ITramiteRepositorio repo)
{
  public void Ejecutar(Tramite t, int IdUser)
  {
    ServicioAutorizacionProvisiorio val = new();
    if (val.PoseeElPermiso(IdUser, Permiso.TramiteModificacion))
    {
      string mensajeError;
      TramiteValidador valid = new();
      if (valid.esValido(t, out mensajeError))
      {
        t.FechayHoraMod = DateTime.Now;
        repo.ModificacionTramite(t, IdUser);
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
