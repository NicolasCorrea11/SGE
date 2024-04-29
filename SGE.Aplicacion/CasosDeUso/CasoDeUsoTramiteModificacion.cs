namespace SGE.Aplicacion;

public class CasoDeUsoTramiteModificacion(ITramiteRepositorio repo)
{
  public void Ejecutar(Tramite t, int idUser)
  {
    repo.ModificacionTramite(t, idUser);
  }
}
