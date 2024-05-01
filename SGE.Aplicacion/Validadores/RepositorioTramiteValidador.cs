namespace SGE.Aplicacion;

public class RepositorioTramiteValidador(IExpedienteRepositorio repoExp, ITramiteRepositorio repoTramite)
{
  public bool EsValido(int id, out string msg)
  {
    msg = "";
    bool existe = false;
    Tramite? tramite = repoTramite.ConsultaPorId(id);
    if (tramite != null)
    {
      List<object> lista = repoExp.ConsultaTodos(tramite.ExpedienteId);
      for (int i = 1; i < lista.Count && !existe; i++)
      {
        if (lista[i] is Tramite actual && actual.Id == id)
        {
          existe = true;
        }
      }
    }
    if (!existe)
    {
      msg += "La entidad que se intenta eliminar, modificar o acceder no existe en el repositorio";
    }
    return msg == "";
  }
}
