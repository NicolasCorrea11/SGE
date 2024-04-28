namespace SGE.Repositorios;
using SGE.Aplicacion;

public class RepositorioTramite : ITramiteRepositorio
{
  readonly string _nomarch = "tramites.txt";

  public void AltaTramite(Tramite t)
  {
    string[] lineas = File.ReadAllLines(_nomarch);
    int id = (lineas.Length / 7) + 1;
    using var sw = new StreamWriter(_nomarch, true);
    sw.WriteLine(id);
    sw.WriteLine(t.ExpedienteId);
    sw.WriteLine(t.Etiqueta);
    sw.WriteLine(t.Contenido);
    sw.WriteLine(t.FechayHoraCr);
    sw.WriteLine(t.FechayHoraMod);
    sw.WriteLine(t.IdUltMod);
  }

  public void ModificacionTramite(Tramite t)
  {
  }
}
