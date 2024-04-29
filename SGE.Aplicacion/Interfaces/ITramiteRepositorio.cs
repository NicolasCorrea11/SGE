namespace SGE.Aplicacion;

public interface ITramiteRepositorio
{
  public void AltaTramite(Tramite t, int idUser);
  public void BajaTramite(int IdTram);
  public void ModificacionTramite(Tramite t, int idUser);
  public List<Tramite> ConsultaPorEtiqueta(EtiquetaTramite etiqueta);
}
