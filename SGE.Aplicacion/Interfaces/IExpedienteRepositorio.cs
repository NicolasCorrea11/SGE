namespace SGE.Aplicacion;

public interface IExpedienteRepositorio
{
    public void AltaExpediente(Expediente e);
    public void BajaExpediente(int id);
}
