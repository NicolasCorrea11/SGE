namespace SGE.Aplicacion;

public class CasoDeUsoTramiteConsultaPorEtiqueta(ITramiteRepositorio repo)
{
  public Tramite Ejecutar(EtiquetaTramite etiqueta)
  {
    return repo.ConsultaPorEtiqueta(etiqueta);
  }
}
