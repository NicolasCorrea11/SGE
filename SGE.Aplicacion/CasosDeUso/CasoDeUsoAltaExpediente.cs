namespace SGE.Aplicacion;

public class CasoDeUsoAltaExpediente(IExpedienteRepositorio repo)
{
    public void Ejecutar(Expediente e, int idUser)
    {   
        e.FechayHoraCr = DateTime.Now;
        e.FechayHoraMod = DateTime.Now;
        repo.AltaExpediente(e, idUser);
    }
}
