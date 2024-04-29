namespace SGE.Aplicacion;

public interface ITramiteRepositorio
{
  public void AltaTramite(Tramite t);
  public void BajaTramite(int IdTram);
  public void ModificacionTramite(Tramite t, int idUser);
  public Tramite ConsultaPorEtiqueta(EtiquetaTramite etiqueta);
}
