namespace SGE.Aplicacion;
public interface IExpedienteRepositorio
{
    public void AltaExpediente(Expediente e, int IdUser);
    public void BajaExpediente(int IdExp, int IdUser);
    public void ModificarExpediente(Expediente e, int id);
    public Expediente ConsultaPorId(int id);
}
