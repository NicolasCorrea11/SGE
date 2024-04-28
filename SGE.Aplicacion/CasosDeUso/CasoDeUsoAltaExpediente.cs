namespace SGE.Aplicacion;

public class CasoDeUsoAltaExpediente(IExpedienteRepositorio repo)
{
    public void Ejecutar(Expediente e)
    {   
        repo.AltaExpediente(e);
    }
}
