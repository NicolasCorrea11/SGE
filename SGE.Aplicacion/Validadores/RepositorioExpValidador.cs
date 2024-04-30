namespace SGE.Aplicacion;

public class RepositorioExpValidador(IExpedienteRepositorio repo)
{
  public bool EsValido(int id, out string msg)
  {
    msg = "";
    if (repo.ConsultaPorId(id) == null)
    {
      msg += "El expediente no existe";
    }
    return msg == "";
  }
}
