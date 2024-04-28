namespace SGE.Aplicacion;

public interface IExpedienteRepositorio
{
    public void AltaExpediente(Expediente e);
    public void BajaExpediente(int id);
    public void ModificarExpediente(Expediente e, int id);
    public Expediente ConsultaPorId(int id);
}
