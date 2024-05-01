namespace SGE.Repositorios;
using SGE.Aplicacion;

public class RepositorioTramite : ITramiteRepositorio
{
  readonly string _nombreArch = "tramites.txt";

  public void AltaTramite(Tramite t)
  {
    string[] lineas = File.ReadAllLines(_nombreArch);
    t.Id = (lineas.Length / 7) + 1;
    using var sw = new StreamWriter(_nombreArch, true);
    CopiarTramite(t, sw);
  }

  public void CopiarTramite(Tramite t, StreamWriter sw)
  {
    sw.WriteLine(t.Id);
    sw.WriteLine(t.ExpedienteId);
    sw.WriteLine(t.Etiqueta);
    sw.WriteLine(t.Contenido);
    sw.WriteLine(t.FechayHoraCr);
    sw.WriteLine(t.FechayHoraMod);
    sw.WriteLine(t.IdUser);
  }

  public Tramite LeerTramite(StreamReader sr)
  {
    Tramite t = new()
      {
        Id = int.Parse(sr.ReadLine() ?? ""),
        ExpedienteId = int.Parse(sr.ReadLine() ?? ""),
        Etiqueta = Enum.Parse<EtiquetaTramite>(sr.ReadLine() ?? ""),
        Contenido = sr.ReadLine(),
        FechayHoraCr = DateTime.Parse(sr.ReadLine() ?? ""),
        FechayHoraMod = DateTime.Parse(sr.ReadLine() ?? ""),
        IdUser = int.Parse(sr.ReadLine() ?? "")
      };
    return t;
  }

  public List<Tramite> ListarTramites()
  {
    using var sr = new StreamReader(_nombreArch);
    List<Tramite> resultado = [];
    while (!sr.EndOfStream)
    {
      Tramite t = LeerTramite(sr);
      resultado.Add(t);
    }
    return resultado;

  }

  public void BajaTramite(int id)
  {
    List<Tramite> lista = ListarTramites();
    File.WriteAllText(_nombreArch, "");
    using var sw = new StreamWriter(_nombreArch, true);
    foreach (Tramite tramite in lista)
    {
      if (tramite.Id != id)
        CopiarTramite(tramite, sw);
    }
  }

  public void BajaTramiteIdExp(int idExp)
  {
    List<Tramite> lista = ListarTramites();
    File.WriteAllText(_nombreArch, "");
    using var sw = new StreamWriter(_nombreArch, true);
    foreach (Tramite t in lista)
    {
      if (t.ExpedienteId != idExp)
        CopiarTramite(t, sw);
    }
  }

  public void ModificacionTramite(Tramite nuevoTramite, int idUser)
  {
    List<Tramite> lista = ListarTramites();
    File.WriteAllText(_nombreArch, "");
    using var sw = new StreamWriter(_nombreArch);
    foreach (Tramite tramite in lista)
    {
      if (tramite.Id != nuevoTramite.Id)
      {
        CopiarTramite(tramite, sw);
      }
      else
      {
        tramite.ExpedienteId = nuevoTramite.ExpedienteId;
        tramite.Etiqueta = nuevoTramite.Etiqueta;
        tramite.Contenido = nuevoTramite.Contenido;
        tramite.FechayHoraMod = DateTime.Now;
        tramite.IdUser = idUser;
        CopiarTramite(tramite, sw);
      }
    }
  }

  public List<Tramite> ConsultaPorEtiqueta(EtiquetaTramite etiqueta)
  {
    List<Tramite> resultado = [];
    foreach (Tramite tramite in ListarTramites())
    {
      if (tramite.Etiqueta == etiqueta)
        resultado.Add(tramite);
    }
    return resultado;
  }

  public Tramite? ConsultaPorId(int id)
  {
    foreach (Tramite t in ListarTramites())
    {
      if (t.Id == id)
        return t;
    }
    return null;
  }

  public List<Tramite> ConsultaPorExpedienteId(int idExp)
  {
    List<Tramite> resultado = [];
    foreach (Tramite t in ListarTramites())
    {
      if (t.ExpedienteId == idExp)
        resultado.Add(t);
    }
    return resultado;
  }
}

