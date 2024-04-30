namespace SGE.Aplicacion;

public class RepositorioTramiteValidador(IExpedienteRepositorio repo)
{
  public bool EsValido(int id, out string msg)
  {
    msg = "";
    bool existe = false;
    List<object> lista = repo.ConsultaTodos(1);  // SIN IMPLEMENTAR
    for (int i = 1; i < lista.Count && !existe; i++)
    {
      if (lista[i] is Tramite actual && actual.Id == id)
      {
        existe = true;
      }
    }
    if (existe)
    {
      msg += "El tramite no existe";
    }
    return msg == "";
  }
}
