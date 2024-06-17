using SGE.Aplicacion;
namespace SGE.Repositorios;

public class RepositorioTramite: ITramiteRepositorio
{
    public void AltaTramite(Tramite t)
    {
        using var context = new BaseContext();
        {
            context.Tramites.Add(t);
        }
        context.SaveChanges();
    }

    public void BajaTramite(int id)
    {
        using var context = new BaseContext();
        {
            Tramite? b = context.Tramites.Where(x => x.Id == id).SingleOrDefault();
            if (b != null)
                context.Tramites.Remove(b);
        }
        context.SaveChanges();
    }

    public void ModificacionTramite(Tramite t, int idUser) 
    {
        using var context = new BaseContext();
        {
            Tramite? trammod = context.Tramites.Where(x => x.Id == t.Id).SingleOrDefault();
            if (trammod != null) 
            {
                if (trammod.Contenido != t.Contenido && t.Contenido != "")
                    trammod.Contenido = t.Contenido;
                if (trammod.Etiqueta != t.Etiqueta && t.Etiqueta.Equals(""))
                    trammod.Etiqueta = t.Etiqueta;
                trammod.FechayHoraMod = DateTime.Now;
                trammod.IdUser = idUser;
            }
            context.SaveChanges();
        }
    }

    public List<Tramite> ConsultaPorEtiqueta(EtiquetaTramite e)
    {
        using var context = new BaseContext();
        {
            var dev = context.Tramites.Where(x => x.Etiqueta == e).ToList();
            return dev;
        }
    }

    public Tramite? ConsultaPorId(int id)
    {
        using var context = new BaseContext();
        {
            Tramite? dev = context.Tramites.Where(x => x.Id == id).SingleOrDefault();
            return dev;
        }
    }

    public List<Tramite> ConsultaPorExpedienteId(int ExpId)
    {
        using var context = new BaseContext();
        {
            var dev = context.Tramites.Where(x => x.ExpedienteId == ExpId).ToList();
            return dev;
        }
    }

}
