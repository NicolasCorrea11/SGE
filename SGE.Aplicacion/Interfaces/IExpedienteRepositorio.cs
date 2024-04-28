namespace SGE.Aplicacion;
public interface IExpedienteRepositorio
{
    public void AltaExpediente(Expediente e);
    public void BajaExpediente(int IdExp);
    public void ModificarExpediente(Expediente e);
    public Expediente ConsultaPorId(int id);
}
