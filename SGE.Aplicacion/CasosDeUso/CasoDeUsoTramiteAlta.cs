namespace SGE.Aplicacion;

public class CasoDeUsoTramiteAlta(ITramiteRepositorio repo)
{
  public void Ejecutar(Tramite t)
  {
    repo.AltaTramite(t);
  }
}
