namespace SGE.Aplicacion;

public interface ITramiteRepositorio
{
  public void AltaTramite(Tramite t);
  public void BajaTramite(int id);
  public void ModificacionTramite(Tramite t, int idUser);
  public List<Tramite> ListarTramites();
  public List<Tramite> ConsultaPorEtiqueta(EtiquetaTramite etiqueta);
  public Tramite? ConsultaPorId(int id);
  public List<Tramite> ConsultaPorExpedienteId(int expedienteId);
}
