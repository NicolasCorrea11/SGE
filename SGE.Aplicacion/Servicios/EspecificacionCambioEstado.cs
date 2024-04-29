namespace SGE.Aplicacion;

public static class EspecificacionCambioEstado
{
  public static EstadoExpediente? GetNuevoEstado(EtiquetaTramite tr)
  {
    switch (tr)
    {
      case EtiquetaTramite.Resolucion:
        return EstadoExpediente.ConResolucion;
      case EtiquetaTramite.PaseAEstudio:
        return EstadoExpediente.ParaResolver;
      case EtiquetaTramite.PaseAlArchivo:
        return EstadoExpediente.Finalizado;
      default:
        return null;
    }
  }
}
