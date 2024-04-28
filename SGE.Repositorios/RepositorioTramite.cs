namespace SGE.Repositorios;
using SGE.Aplicacion;

public class RepositorioTramite: ITramiteRepositorio
{
  readonly string _nomarch = "tramites.txt";

  public void AltaTramite(Tramite t)
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

