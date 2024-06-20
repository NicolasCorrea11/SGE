using Microsoft.EntityFrameworkCore;
using SGE.Aplicacion;
namespace SGE.Repositorios;

public class RepositorioExpediente : IExpedienteRepositorio
{
    public void AltaExpediente(Expediente e)
    {
        using var context = new BaseContext();
        context.Expedientes.Add(e);
        context.SaveChanges();
    }

    public void BajaExpediente(int id)
    {
        using var context = new BaseContext();
        Expediente? e = context.Expedientes.Where(t => t.Id == id).SingleOrDefault();
        if (e != null)
        {
            context.Expedientes.Remove(e);
        }
        //var trams = context.Tramites.Where(x => x.ExpedienteId == id).ToList();
        //context.Tramites.RemoveRange(trams);
        context.SaveChanges();
    }

    public void ModificarExpediente(Expediente nuevoE, int id)
    {
        using var context = new BaseContext();
        var e = context.Expedientes.Where(e => e.Id == nuevoE.Id).SingleOrDefault();
        if (e != null)
        {
            e.Caratula = nuevoE.Caratula;
            e.Estado = nuevoE.Estado;
            e.FechayHoraMod = DateTime.Now;
            e.IdUser = id;
        }
        context.SaveChanges();
    }

    public Expediente? ConsultaPorId(int id)
    {
        using var context = new BaseContext();
        Expediente? e = context.Expedientes.Where(e => e.Id == id).SingleOrDefault();
        return e;
    }

    public List<object> ConsultaTodos(int id)
    {
        using var context = new BaseContext();
        List<object> lista = [];
        Expediente? exp = context.Expedientes.Where(e => e.Id == id).SingleOrDefault();
        if (exp != null)
        {
            lista.Add(exp);
            var tramites = context.Tramites.Where(t => t.ExpedienteId == id).ToList();
            lista.AddRange(tramites);
        }
        return lista;
    }

    public List<Expediente> ListarExpedientes()
    {
        using var context = new BaseContext();
        return context.Expedientes.ToList();
    }
}
