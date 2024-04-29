namespace SGE.Aplicacion;

public class CasoDeUsoTramiteModificacion(ITramiteRepositorio repo)
{
  public void Ejecutar(Tramite t, int IdUser)
  {
    ServicioAutorizacionProvisiorio val = new();
    if (val.PoseeElPermiso(IdUser, Permiso.TramiteModificacion))
    {
      repo.ModificacionTramite(t, IdUser);
    }
    else
    {
      throw new AutorizacionException("No se tienen los permisos necesarios");
    }
    
  }
}
