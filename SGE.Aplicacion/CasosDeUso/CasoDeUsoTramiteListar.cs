namespace SGE.Aplicacion;

public class CasoDeUsoTramiteListar(ITramiteRepositorio repoTram)
{
  public List<Tramite> Ejecutar()
  {
    return repoTram.ListarTramites();
  }
}
