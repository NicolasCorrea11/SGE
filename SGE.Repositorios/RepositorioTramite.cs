using SGE.Aplicacion;
namespace SGE.Repositorios;

public class RepositorioTramite: ITramiteRepositorio
{
    public void AltaTramite(Tramite t)
    {
        using var context = new BaseContext();
        {
            context.Tramites.Add(t);
            context.SaveChanges();
        }
    }

    public void BajaTramite(int id)
    {
        using var context = new BaseContext();
        {
            Tramite? b = context.Tramites.Where(x => x.Id == id).SingleOrDefault();
            if (b != null)
                context.Tramites.Remove(b);
            context.SaveChanges();
        }
    }

    public void ModificacionTramite(Tramite t, int idUser) 
    {
        using var context = new BaseContext();
        {
            Tramite? modificado = context.Tramites.Where(x => x.Id == t.Id).SingleOrDefault();
            if (modificado != null) 
            {
                if (modificado.Contenido != t.Contenido && t.Contenido != "")
                    modificado.Contenido = t.Contenido;
                if (modificado.Etiqueta != t.Etiqueta && t.Etiqueta.Equals(""))
                    modificado.Etiqueta = t.Etiqueta;
                modificado.FechayHoraMod = DateTime.Now;
                modificado.IdUser = idUser;
            }
            context.SaveChanges();
        }
    }

    public List<Tramite> ConsultaPorEtiqueta(EtiquetaTramite e)
    {
        using var context = new BaseContext();
        {
            return context.Tramites.Where(x => x.Etiqueta == e).ToList();
        }
    }

    public Tramite? ConsultaPorId(int id)
    {
        using var context = new BaseContext();
        {
            return context.Tramites.Where(x => x.Id == id).SingleOrDefault();
        }
    }

    public List<Tramite> ConsultaPorExpedienteId(int expId)
    {
        using var context = new BaseContext();
        {
            return context.Tramites.Where(x => x.ExpedienteId == expId).ToList();
        }
    }

}
