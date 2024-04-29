namespace SGE.Repositorios;
using SGE.Aplicacion;
using System.IO;

public class RepositorioExpediente : IExpedienteRepositorio
{
    readonly string _nomarch = "expedientes.txt";

    public void AltaExpediente(Expediente e)
    {
        string[] lineas = File.ReadAllLines(_nomarch);
        int id = (lineas.Length / 6) + 1;
        using var sw = new StreamWriter(_nomarch, true);
        sw.WriteLine(id);
        sw.WriteLine(e.Caratula);
        sw.WriteLine(e.FechayHoraCr);
        sw.WriteLine(e.FechayHoraMod);
        sw.WriteLine(e.IdUltMod);
        sw.WriteLine(e.Estado);
    }

    public List<Expediente> ListarExps()
    {
        using var sr = new StreamReader(_nomarch);
        List<Expediente> resultado = [];
        while (!sr.EndOfStream)
        {
            Expediente expe = new()
            {
                Id = int.Parse(sr.ReadLine() ?? ""),
                Caratula = sr.ReadLine() ?? "",
                FechayHoraCr = DateTime.Parse(sr.ReadLine() ?? ""),
                FechayHoraMod = DateTime.Parse(sr.ReadLine() ?? ""),
                IdUltMod = int.Parse(sr.ReadLine() ?? ""),
                Estado = Enum.Parse<EstadoExpediente>(sr.ReadLine() ?? ""),
            };
            resultado.Add(expe);
        }
        return resultado;
    }

    public void BajaExpediente(int idExp)
    {
        List<Expediente> lista = ListarExps();
        File.WriteAllText(_nomarch, "");
        using var sw = new StreamWriter(_nomarch, true);
        foreach (Expediente exp in lista)
        {
            if (exp.Id != idExp)
            {
                sw.WriteLine(exp.Id);
                sw.WriteLine(exp.Caratula);
                sw.WriteLine(exp.FechayHoraCr);
                sw.WriteLine(exp.FechayHoraMod);
                sw.WriteLine(exp.IdUltMod);
                sw.WriteLine(exp.Estado);
            }
        }
        sw.Close();
        RepositorioTramite rep = new();
        List<Tramite> listram = rep.ListarTramites();
        File.WriteAllText("tramites.txt", "");
        using var stw = new StreamWriter("tramites.txt", true);
        foreach(Tramite t in listram)
        {
            if(t.ExpedienteId != idExp)
            {
                stw.WriteLine(t.Id);
                stw.WriteLine(t.ExpedienteId);
                stw.WriteLine(t.Etiqueta);
                stw.WriteLine(t.Contenido);
                stw.WriteLine(t.FechayHoraCr);
                stw.WriteLine(t.FechayHoraMod);
                stw.WriteLine(t.IdUltMod);
            }
        }
        stw.Close();

    }

    public void ModificarExpediente(Expediente nuevoExp, int idUser)
    {
        List<Expediente> lista = ListarExps();
        File.WriteAllText(_nomarch, "");
        foreach (Expediente exp in lista)
        {
            if (exp.Id == nuevoExp.Id)
            {
                using var sw = new StreamWriter(_nomarch, true);
                sw.WriteLine(exp.Id);
                sw.WriteLine(nuevoExp.Caratula);
                sw.WriteLine(exp.FechayHoraCr);
                sw.WriteLine(DateTime.Now);
                sw.WriteLine(idUser);
                sw.WriteLine(nuevoExp.Estado);
                sw.Close();
            }
            else
                AltaExpediente(exp);
        }
    }

    public Expediente ConsultaPorId(int id)
    {
        Expediente resultado = new();
        List<Expediente> lista = ListarExps();
        foreach (Expediente exp in lista)
        {
            if (id == exp.Id)
                resultado = exp;
        }
        return resultado;
    }

    public List<object> ConsultaTodos(int idExp)
    {
        List<object> resultado = new();
        List<Expediente> lista = ListarExps();
        int i = 0;
        while(lista[i].Id != idExp)
        {
            i++;
        }
        resultado.Add(lista[i]);
        using var sr = new StreamReader("tramites.txt");
        RepositorioTramite rep = new();
        List<Tramite> listram = rep.ListarTramites();
        foreach(Tramite t in listram)
        {
            if (t.ExpedienteId == idExp)
            {
                resultado.Add(t);
            }
        }
        return resultado;
    }
}
