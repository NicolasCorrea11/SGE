namespace SGE.Aplicacion;

public class CasoDeUsoExpedienteAlta(IExpedienteRepositorio repoExp)
{
    public void Ejecutar(Expediente e)
    {
        e.FechayHoraCr = DateTime.Now;
        e.FechayHoraMod = DateTime.Now;
        repoExp.AltaExpediente(e);
    }
}
