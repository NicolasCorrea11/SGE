namespace SGE.Aplicacion;

public class CasoDeUsoConsultaPorExpedienteId(ITramiteRepositorio repoTram)
{
  public List<Tramite> Ejecutar(int expId)
  {
    return repoTram.ConsultaPorExpedienteId(expId);
  }
}
