using SGE.Aplicacion;
using System.IO;
namespace SGE.Repositorios;

public class RepositorioExpediente : IExpedienteRepositorio
{
    readonly string _nomarch = "expedientes.txt";
    public void AltaExpediente(Expediente e)
    {
<<<<<<< HEAD
        string[] lineas = File.ReadAllLines(_nomarch);
        int id = (lineas.Length / 6) + 1;
        using var sw = new StreamWriter(_nomarch, true);
        sw.WriteLine(id);
        sw.WriteLine(e.Caratula);
        sw.WriteLine(e.FechayHoraCr);
        sw.WriteLine(e.FechayHoraMod);
        sw.WriteLine(e.IdUltMod);
        sw.WriteLine(e.Estado);
=======
        int id = 1;
        using var sw = new StreamWriter(_nomarch, true);
        if (sw.BaseStream.Length == 0)
        {
            sw.WriteLine(id);
            sw.WriteLine(e.Caratula);
            sw.WriteLine(e.FechayHoraCr);
            sw.WriteLine(e.FechayHoraMod);
            sw.WriteLine(e.IdUltMod);
            sw.WriteLine(e.Estado);
            sw.Close();
        }
        else
        {
            sw.Close();
            using var cont = new StreamReader(_nomarch);
            int filas = 0;
            while (cont.ReadLine() != null)
            {
                filas++;
            }
            cont.Close();
            using var srr = new StreamReader(_nomarch);
            for (int i = 0; i < filas-6; i++)
            {
                srr.ReadLine();
            }
            id = int.Parse(srr.ReadLine() ?? "");
            id++;
            srr.Close();
            using var stw = new StreamWriter(_nomarch, true);
            stw.WriteLine(id);
            stw.WriteLine(e.Caratula);
            stw.WriteLine(e.FechayHoraCr);
            stw.WriteLine(e.FechayHoraMod);
            stw.WriteLine(e.IdUltMod);
            stw.WriteLine(e.Estado);
            stw.Close();
        }
>>>>>>> 2ab853e9e261e6cd848c2fed6f79230b5d521099
    }

    public List<Expediente> ListarExps()
    {
        using var sr = new StreamReader(_nomarch);
        var resultado = new List<Expediente>();
        while (!sr.EndOfStream)
        {
            var expe = new Expediente();
            expe.Id = int.Parse(sr.ReadLine() ?? "");
            expe.Caratula = sr.ReadLine() ?? "";
            expe.FechayHoraCr = DateTime.Parse(sr.ReadLine() ?? "");
            expe.FechayHoraMod = DateTime.Parse(sr.ReadLine() ?? "");
            expe.IdUltMod = int.Parse(sr.ReadLine() ?? "");
            resultado.Add(expe);
        }
        return resultado;
    }

    public void BajaExpediente(int idExp)
    {
        List<Expediente> lista = ListarExps();
        File.WriteAllText(_nomarch, "");
        foreach (Expediente exp in lista)
        {
            if (exp.Id != idExp)
            {
                AltaExpediente(exp);
<<<<<<< HEAD
            }
        }
=======
            }   
        }       
>>>>>>> 2ab853e9e261e6cd848c2fed6f79230b5d521099
    }

    public void ModificarExpediente(Expediente e)
    {
        List<Expediente> lista = ListarExps();
        int i = 0;
        while (lista[i].Id != e.Id)
        {
<<<<<<< HEAD
            List<Expediente> lista = ListarExps();
            int i = 0;
            while (lista[i].Id != e.Id)
            {
                i++;
            }
            lista[i] = e;
            File.WriteAllText(_nomarch, "");
            using var sw = new StreamWriter(_nomarch, true);
            foreach (Expediente exp in lista)
            {
                AltaExpediente(exp);
            }
=======
            i++;
        }
        lista[i] = e;
        File.WriteAllText(_nomarch, "");
        using var sw = new StreamWriter(_nomarch, true);
        foreach (Expediente exp in lista)
        {
            AltaExpediente(exp);
>>>>>>> 2ab853e9e261e6cd848c2fed6f79230b5d521099
        }
    }

    public Expediente ConsultaPorId(int id)
    {
        var exp = new Expediente();
        var lista = ListarExps();
        foreach (Expediente e in lista)
        {
            if (id == e.Id)
            {
                exp = e;
            }
        }
        return exp;
    }
}
