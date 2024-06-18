namespace SGE.Aplicacion;

public class CasoDeUsoTramiteConsultaId(ITramiteRepositorio repoTram)
{
  public Tramite Ejecutar(int id)
  {
    Tramite? t = repoTram.ConsultaPorId(id);
    if (t == null)
    {
      throw new RepositorioException("El tramite no existe");
    }
    else
    {
      return t;
    }
  }
}
