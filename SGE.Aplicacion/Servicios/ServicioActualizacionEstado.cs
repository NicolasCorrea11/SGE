namespace SGE.Aplicacion;

public class ServicioActualizacionEstado(IExpedienteRepositorio repo)
{
  public void ActualizarEstado(int id)
  {
    List<object> lista = repo.ConsultaTodos(id);
    Tramite tramite = (Tramite) lista[lista.Count - 1];
    EstadoExpediente? nuevoEstado = EspecificacionCambioEstado.GetNuevoEstado(tramite.Etiqueta);
    Expediente? exp = repo.ConsultaPorId(id);
    if (exp != null && nuevoEstado != null)
    {
      exp.Estado = nuevoEstado;
      repo.ModificarExpediente(exp, 1);
    }
  }
}
