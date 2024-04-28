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

  public List<Tramite> ListarTramites()
  {
    using var sr = new StreamReader(_nomarch);
    var resultado = new List<Tramite>();
    while (!sr.EndOfStream)
    {
      var tr = new Tramite();
      tr.Id = int.Parse(sr.ReadLine() ?? "");
      tr.ExpedienteId = int.Parse(sr.ReadLine() ?? "");
      tr.Etiqueta = Enum.Parse<EtiquetaTramite>(sr.ReadLine() ?? ""); 
      tr.Contenido = sr.ReadLine();
      tr.FechayHoraCr = DateTime.Parse(sr.ReadLine() ?? "");
      tr.FechayHoraMod = DateTime.Parse(sr.ReadLine() ?? "");
      tr.IdUltMod = int.Parse(sr.ReadLine() ?? "");
      resultado.Add(tr);
    }
    return resultado;

  }
  public void BajaTramite(int IdTram)
  {
    List<Tramite> lista = ListarTramites();
    File.WriteAllText(_nomarch, "");
    foreach (Tramite tra in lista)
    {
      if (tra.Id != IdTram)
      {
        AltaTramite(tra);
      }   
    } 
  }
}

