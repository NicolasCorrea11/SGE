namespace SGE.Aplicacion;

public class CasoDeUsoTramiteConsultaPorEtiqueta(ITramiteRepositorio repo)
{
  public List<Tramite> Ejecutar(EtiquetaTramite etiqueta)
  {
    return repo.ConsultaPorEtiqueta(etiqueta);
  }
}
