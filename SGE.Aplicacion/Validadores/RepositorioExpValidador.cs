namespace SGE.Aplicacion;

public class RepositorioExpValidador(IExpedienteRepositorio repo)
{
  public bool EsValido(int id, out string msg)
  {
    msg = "";
    if (repo.ConsultaPorId(id) == null)
    {
      msg += "La entidad que se intenta eliminar, modificar o acceder no existe en el repositorio";
    }
    return msg == "";
  }
}
