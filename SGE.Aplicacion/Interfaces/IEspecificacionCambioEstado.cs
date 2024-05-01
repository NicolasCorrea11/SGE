namespace SGE.Aplicacion;

public interface IEspecificacionCambioEstado
{
  public EstadoExpediente? GetEstado(EtiquetaTramite etiqueta);
}
