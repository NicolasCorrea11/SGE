using SGE.Aplicacion;

namespace SGE.Repositorios;

public class RepositorioExpediente: IExpedienteRepositorio
{
    readonly string _nomarch = "expedientes.txt";
    public void AltaExpediente(Expediente e)
    {
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
            for (int i = 0; i<filas-6;i++)
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
    }

}
