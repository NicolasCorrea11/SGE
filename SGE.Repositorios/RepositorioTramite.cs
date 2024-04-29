namespace SGE.Repositorios;
<<<<<<< HEAD

using System.ComponentModel;
using System.Linq.Expressions;
=======
>>>>>>> c987ec2c7c698de088ef621f5e5b04f0d1ee06bc
using SGE.Aplicacion;

public class RepositorioTramite : ITramiteRepositorio
{
  readonly string _nomarch = "tramites.txt";

  public void AltaTramite(Tramite tramite, int idUser)
  {
    string[] lineas = File.ReadAllLines(_nomarch);
    tramite.Id = (lineas.Length / 7) + 1;
    tramite.IdUser = idUser;
    using var sw = new StreamWriter(_nomarch, true);
    CopiarTramite(tramite, sw);
  }

  public void CopiarTramite(Tramite tramite, StreamWriter sw)
  {
    sw.WriteLine(tramite.Id);
    sw.WriteLine(tramite.ExpedienteId);
    sw.WriteLine(tramite.Etiqueta.ToString());
    sw.WriteLine(tramite.Contenido);
    sw.WriteLine(tramite.FechayHoraCr);
    sw.WriteLine(tramite.FechayHoraMod);
    sw.WriteLine(tramite.IdUser);
  }

  public Tramite LeerTramite(StreamReader sr)
  {
    Tramite tramite = new()
      {
        Id = int.Parse(sr.ReadLine() ?? ""),
        ExpedienteId = int.Parse(sr.ReadLine() ?? ""),
        Etiqueta = Enum.Parse<EtiquetaTramite>(sr.ReadLine() ?? ""),
        Contenido = sr.ReadLine(),
        FechayHoraCr = DateTime.Parse(sr.ReadLine() ?? ""),
        FechayHoraMod = DateTime.Parse(sr.ReadLine() ?? ""),
        IdUser = int.Parse(sr.ReadLine() ?? "")
      };
    return tramite;
  }

  public List<Tramite> ListarTramites()
  {
    using var sr = new StreamReader(_nomarch);
    List<Tramite> resultado = [];
    while (!sr.EndOfStream)
    {
      Tramite tramite = LeerTramite(sr);
      resultado.Add(tramite);
    }
    return resultado;

  }

  public int BajaTramite(int id)
  {
    List<Tramite> lista = ListarTramites();
    int resultado = -1;
    File.WriteAllText(_nomarch, "");
    using var sw = new StreamWriter(_nomarch, true);
    foreach (Tramite tramite in lista)
    {
<<<<<<< HEAD
      if (tra.Id != IdTram)
      {
        sw.WriteLine(tra.Id);
        sw.WriteLine(tra.ExpedienteId);
        sw.WriteLine(tra.Etiqueta);
        sw.WriteLine(tra.Contenido);
        sw.WriteLine(tra.FechayHoraCr);
        sw.WriteLine(tra.FechayHoraMod);
        sw.WriteLine(tra.IdUser);
      }
=======
      if (tramite.Id != id)
        CopiarTramite(tramite, sw);
      else
        resultado = tramite.ExpedienteId;
>>>>>>> c987ec2c7c698de088ef621f5e5b04f0d1ee06bc
    }
    return resultado;
  }

  public void ModificacionTramite(Tramite nuevoTramite, int idUser)
  {
    List<Tramite> lista = ListarTramites();
    File.WriteAllText(_nomarch, "");
    using var sw = new StreamWriter(_nomarch);
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
<<<<<<< HEAD
    List<Tramite> lista = ListarTramites();
    foreach (Tramite t in lista)
    {
      if (t.Etiqueta == etiqueta)
        resultado.Add(t);
=======
    foreach (Tramite tramite in ListarTramites())
    {
      if (tramite.Etiqueta == etiqueta)
        resultado.Add(tramite);
>>>>>>> c987ec2c7c698de088ef621f5e5b04f0d1ee06bc
    }
    return resultado;
  }
}

