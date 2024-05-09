namespace SGE.Repositorios;
using SGE.Aplicacion;
using System.IO;

public class RepositorioExpediente(ITramiteRepositorio repoTramite) : IExpedienteRepositorio
{
    readonly string _nombreArch = "expedientes.txt";

    public void AltaExpediente(Expediente e)
    {
        string[] lineas = File.ReadAllLines(_nombreArch);
        if (lineas.Length == 0) 
        {
            e.Id = 1;
            using var sw = new StreamWriter(_nombreArch, true);
            CopiarExpediente(e, sw);
        }
        else
        {
            using var sr = new StreamReader(_nombreArch);
            for (int i = 0; i<lineas.Length - 6; i++)
            {
                sr.ReadLine();
            }
            e.Id = int.Parse(sr.ReadLine() ?? "") + 1;
            sr.Close();
            using var sw = new StreamWriter(_nombreArch, true);
            CopiarExpediente(e, sw);
        }
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
        Expediente e = new()
        {
            Id = int.Parse(sr.ReadLine() ?? ""),
            Caratula = sr.ReadLine() ?? "",
            FechayHoraCr = DateTime.Parse(sr.ReadLine() ?? ""),
            FechayHoraMod = DateTime.Parse(sr.ReadLine() ?? ""),
            IdUser = int.Parse(sr.ReadLine() ?? ""),
            Estado = Enum.Parse<EstadoExpediente>(sr.ReadLine() ?? "")
        };
        return e;
    }

    public List<Expediente> ListarExpedientes()
    {
        List<Expediente> resultado = [];
        using var sr = new StreamReader(_nombreArch);
        while (!sr.EndOfStream)
        {
            Expediente e = LeerExpediente(sr);
            resultado.Add(e);
        }
        return resultado;
    }

    public void BajaExpediente(int idExp)
    {
        List<Expediente> listaExps = ListarExpedientes();
        File.WriteAllText(_nombreArch, "");
        using var sw = new StreamWriter(_nombreArch, true);
        foreach (Expediente e in listaExps)
        {
            if (e.Id != idExp)
            {
                CopiarExpediente(e, sw);
            }
        }
        RepositorioTramite repo = new();
        repo.BajaTramiteIdExp(idExp);
    }

    public void ModificarExpediente(Expediente nuevoExp, int idUser)
    {
        List<Expediente> lista = ListarExpedientes();
        File.WriteAllText(_nombreArch, "");
        using var sw = new StreamWriter(_nombreArch, true);
        foreach (Expediente e in lista)
        {
            if (e.Id == nuevoExp.Id)
            {
                e.Caratula = nuevoExp.Caratula;
                e.Estado = nuevoExp.Estado;
                e.IdUser = idUser;
                e.FechayHoraMod = DateTime.Now;
                CopiarExpediente(e, sw);
            }
            else
                CopiarExpediente(e, sw);
        }
    }

    public Expediente? ConsultaPorId(int id)
    {
        foreach (Expediente e in ListarExpedientes())
        {
            if (id == e.Id)
                return e;
        }
        return null;
    }

    public List<object> ConsultaTodos(int id)
    {
        List<object> resultado = [];
        Expediente? e = ConsultaPorId(id);
        if (e != null)
        {
            resultado.Add(e);
            foreach (Tramite t in repoTramite.ConsultaPorExpedienteId(id))
            {
                resultado.Add(t);
            }
        }
        return resultado;
    }
}
