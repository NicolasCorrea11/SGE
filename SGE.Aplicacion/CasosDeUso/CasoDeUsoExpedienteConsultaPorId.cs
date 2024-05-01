namespace SGE.Aplicacion;

public class CasoDeUsoExpedienteConsultaPorId(IExpedienteRepositorio repo, RepositorioExpValidador validador)
{
  public Expediente? Ejecutar(int id)
  {
    if (!validador.EsValido(id, out string msg))
    {
      throw new RepositorioException(msg);
    }
    else
    {
      return repo.ConsultaPorId(id);
    }
  }
}
