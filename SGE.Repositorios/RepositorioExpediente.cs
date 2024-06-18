using Microsoft.EntityFrameworkCore;
using SGE.Aplicacion;
namespace SGE.Repositorios;

public class RepositorioExpediente: IExpedienteRepositorio
{
    public void AltaExpediente(Expediente e) 
    {
        using var context = new BaseContext();
        {
            context.Expedientes.Add(e);
            context.SaveChanges();
        }
    }

    public void BajaExpediente(int id)
    {
        using var context = new BaseContext();
        {
            Expediente? b = context.Expedientes.Where(x => x.Id == id).SingleOrDefault();
            if (b != null) 
            {
                context.Expedientes.Remove(b);
            }
            //var trams = context.Tramites.Where(x => x.ExpedienteId == id).ToList();
            //context.Tramites.RemoveRange(trams);
            context.SaveChanges();
        }
    }
    
    public void ModificarExpediente(Expediente e, int id) 
    {
        using var context = new BaseContext();
        {
            var expmod = context.Expedientes.Where(x => x.Id == e.Id).SingleOrDefault();
            if (expmod != null)
            {
                if (expmod.Caratula != e.Caratula && e.Caratula!= "")
                    expmod.Caratula = e.Caratula;
                if (expmod.Estado != e.Estado && e.Estado.Equals(""))
                    expmod.Estado = e.Estado;
                expmod.FechayHoraMod = DateTime.Now;
                expmod.IdUser = id;
            }
            context.SaveChanges();
        }
    }

    public Expediente? ConsultaPorId(int idb) 
    {
        using var context = new BaseContext();
        {
            Expediente? dev = context.Expedientes.Where(x => x.Id == idb).SingleOrDefault();
            return dev;
        }
    }

    public List<object> ConsultaTodos(int id)
    {
        using var context = new BaseContext();
        {
            List<object> dev = new();
            var exp = context.Expedientes.Where(x => x.Id == id).SingleOrDefault();
            if (exp != null)
                dev.Add(exp);
            var trams = context.Tramites.Where(x => x.ExpedienteId == id).ToList();
            dev.AddRange(trams);
            return dev;
        }
    }

    public List<Expediente> ListarExpedientes() 
    {
        using var context = new BaseContext();
        {
            var dev = context.Expedientes.ToList();
            return dev;
        }
    }
}
