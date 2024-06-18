namespace SGE.Aplicacion;

public class CasoDeUsoTramiteConsultaEtiqueta(ITramiteRepositorio repoTram)
{
  public List<Tramite> Ejecutar(EtiquetaTramite etiqueta)
  {
    return repoTram.ConsultaPorEtiqueta(etiqueta);
  }
}
