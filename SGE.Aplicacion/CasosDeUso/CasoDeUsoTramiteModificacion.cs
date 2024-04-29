namespace SGE.Aplicacion;

public class CasoDeUsoTramiteModificacion(ITramiteRepositorio repo)
{
  public void Ejecutar(Tramite t)
  {
    repo.ModificacionTramite(t);
  }
}
