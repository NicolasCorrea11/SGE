namespace SGE.Aplicacion;

public class EspecificacionCambioEstado
{
  public EstadoExpediente? GetEstado(EtiquetaTramite etiqueta)
  {
    return etiqueta switch
    {
      EtiquetaTramite.Resolucion => EstadoExpediente.ConResolucion,
      EtiquetaTramite.PaseAEstudio => EstadoExpediente.ParaResolver,
      EtiquetaTramite.PaseAlArchivo => EstadoExpediente.Finalizado,
      _ => null,
    };
  }
}
