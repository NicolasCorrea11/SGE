namespace SGE.Repositorios;

using System.Linq.Expressions;
using SGE.Aplicacion;

public class RepositorioTramite : ITramiteRepositorio
{
  readonly string _nomarch = "tramites.txt";

  public void AltaTramite(Tramite t, int idUser)
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
    sw.WriteLine(idUser);
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
        IdUser = int.Parse(sr.ReadLine() ?? "")
      };
      resultado.Add(tr);
    }
    return resultado;

  }
  
  public void BajaTramite(int IdTram)
  {
    List<Tramite> lista = ListarTramites();
    File.WriteAllText(_nomarch, "");
    using var sw = new StreamWriter(_nomarch, true);
    foreach (Tramite tra in lista)
    {
      if (tra.Id != IdTram)
      {
        sw.WriteLine(tra.Id);
        sw.WriteLine(tra.ExpedienteId);
        sw.WriteLine(tra.Etiqueta);
        sw.WriteLine(tra.Contenido);
        sw.WriteLine(tra.FechayHoraCr);
        sw.WriteLine(tra.FechayHoraMod);
        sw.WriteLine(tra.IdUltMod);
      }
    }
  }

  public void ModificacionTramite(Tramite nuevoTramite, int idUser)
  {
    List<Tramite> lista = ListarTramites();
    File.WriteAllText(_nomarch, "");
    foreach (Tramite t in lista)
    {
      if (t.Id == nuevoTramite.Id)
      {
        using var sw = new StreamWriter(_nomarch, true);
        sw.WriteLine(t.Id);
        sw.WriteLine(nuevoTramite.ExpedienteId);
        sw.WriteLine(nuevoTramite.Etiqueta);
        sw.WriteLine(nuevoTramite.Contenido);
        sw.WriteLine(t.FechayHoraCr);
        sw.WriteLine(DateTime.Now);
        sw.WriteLine(idUser);
        sw.Close();
      }
      else
      {
        AltaTramite(t);
      }
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

