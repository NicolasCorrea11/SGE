namespace SGE.Aplicacion;

public class CasoDeUsoTramiteConsultaExpId(ITramiteRepositorio repoTram)
{
  public List<Tramite> Ejecutar(int expId)
  {
    return repoTram.ConsultaPorExpedienteId(expId);
  }
}
