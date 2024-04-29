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

  public List<Tramite> ListarTramites()
  {
    using var sr = new StreamReader(_nomarch);
    List<Tramite> resultado = [];
    while (!sr.EndOfStream)
    {
      Tramite tr = new()
      {
        Id = int.Parse(sr.ReadLine() ?? ""),
        ExpedienteId = int.Parse(sr.ReadLine() ?? ""),
        Etiqueta = Enum.Parse<EtiquetaTramite>(sr.ReadLine() ?? ""),
        Contenido = sr.ReadLine(),
        FechayHoraCr = DateTime.Parse(sr.ReadLine() ?? ""),
        FechayHoraMod = DateTime.Parse(sr.ReadLine() ?? ""),
        IdUltMod = int.Parse(sr.ReadLine() ?? "")
      };
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
        AltaTramite(tra);
    }
  }

  public void ModificacionTramite(Tramite nuevoTramite)
  {
    List<Tramite> lista = ListarTramites();
    File.WriteAllText(_nomarch, "");
    foreach (Tramite t in lista)
    {
      if (nuevoTramite.Id == t.Id)
        AltaTramite(nuevoTramite);
      else
        AltaTramite(t);
    }
  }

  public Tramite ConsultaPorEtiqueta(EtiquetaTramite etiqueta)
  {
    Tramite resultado = new();
    List<Tramite> lista = ListarTramites();
    foreach (Tramite t in lista)
    {
      if (t.Etiqueta == etiqueta)
        resultado = t;
    }
    return resultado;
  }
}

