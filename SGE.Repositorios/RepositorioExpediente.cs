namespace SGE.Repositorios;
using SGE.Aplicacion;
using System.IO;

public class RepositorioExpediente : IExpedienteRepositorio
{
    readonly string _nomarch = "expedientes.txt";

    public void AltaExpediente(Expediente e, int idUser)
    {
        string[] lineas = File.ReadAllLines(_nomarch);
        e.Id = (lineas.Length / 6) + 1;
        using var sw = new StreamWriter(_nomarch, true);
        sw.WriteLine(e.Id);
        sw.WriteLine(e.Caratula);
        sw.WriteLine(e.FechayHoraCr);
        sw.WriteLine(e.FechayHoraMod);
        sw.WriteLine(idUser);
        sw.WriteLine(e.Estado);
    }

    public void CopiarExpediente(Expediente e, StreamWriter sw)
    {
        sw.WriteLine(e.Id);
        sw.WriteLine(e.Caratula);
        sw.WriteLine(e.FechayHoraCr);
        sw.WriteLine(e.FechayHoraMod);
        sw.WriteLine(e.IdUser);
        sw.WriteLine(e.Estado);
    }

    public Expediente LeerExpediente(StreamReader sr)
    {
        Expediente exp = new()
        {
            Id = int.Parse(sr.ReadLine() ?? ""),
            Caratula = sr.ReadLine() ?? "",
            FechayHoraCr = DateTime.Parse(sr.ReadLine() ?? ""),
            FechayHoraMod = DateTime.Parse(sr.ReadLine() ?? ""),
            IdUser = int.Parse(sr.ReadLine() ?? ""),
            Estado = Enum.Parse<EstadoExpediente>(sr.ReadLine() ?? "")
        };
        return exp;
    }

    public List<Expediente> ListarExps()
    {
        using var sr = new StreamReader(_nomarch);
        List<Expediente> resultado = [];
        while (!sr.EndOfStream)
        {
            Expediente expe = LeerExpediente(sr);
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
                CopiarExpediente(exp, sw);
            }
        }
    }

    public void ModificarExpediente(Expediente nuevoExp, int idUser)
    {
        List<Expediente> lista = ListarExps();
        File.WriteAllText(_nomarch, "");
        using var sw = new StreamWriter(_nomarch, true);
        foreach (Expediente exp in lista)
        {
            if (exp.Id == nuevoExp.Id)
            {
                exp.Caratula = nuevoExp.Caratula;
                exp.FechayHoraMod = DateTime.Now;
                exp.Estado = nuevoExp.Estado;
                exp.IdUser = idUser;
                CopiarExpediente(exp, sw);
            }
            else
                CopiarExpediente(exp, sw);
        }
    }

    public Expediente? ConsultaPorId(int id)
    {
        foreach (Expediente exp in ListarExps())
        {
            if (id == exp.Id)
                return exp;
        }
        return null;
    }

    public List<object> ConsultaTodos(int idExp)
    {
        List<object> resultado = [];
        foreach (Expediente e in ListarExps())
        {
            if (idExp == e.Id)
                resultado.Add(e);
        }
        using var sr = new StreamReader("tramites.txt");
        RepositorioTramite repo = new();
        foreach (Tramite t in repo.ListarTramites())
        {
            if (t.ExpedienteId == idExp)
                resultado.Add(t);
        }
        return resultado;
    }
}
