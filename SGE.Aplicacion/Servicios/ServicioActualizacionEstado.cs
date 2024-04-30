namespace SGE.Aplicacion;

public class ServicioActualizacionEstado(IExpedienteRepositorio repo, EspecificacionCambioEstado especificacion) : IServicioActualizacionEstado
{
  public void ActualizarEstado(int id)
  {
    List<object> lista = repo.ConsultaTodos(id);
    if (lista[lista.Count - 1] is Tramite t)
    {
      Expediente? e = repo.ConsultaPorId(id);
      EstadoExpediente? nuevoEstado = especificacion.GetEstado(t.Etiqueta);
      if (e != null && nuevoEstado != null)
      {
        e.Estado = nuevoEstado;
        repo.ModificarExpediente(e, 1);
      }
    }
  }
}
