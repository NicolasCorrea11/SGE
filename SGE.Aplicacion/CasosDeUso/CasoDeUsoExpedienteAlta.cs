namespace SGE.Aplicacion;

public class CasoDeUsoExpedienteAlta(IExpedienteRepositorio repo)
{
    public void Ejecutar(Expediente e, int idUser)
    {   
        e.FechayHoraCr = DateTime.Now;
        e.FechayHoraMod = DateTime.Now;
        repo.AltaExpediente(e, idUser);
    }
}
