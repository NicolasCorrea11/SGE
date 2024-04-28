namespace SGE.Aplicacion;
public interface IExpedienteRepositorio
{
    public void AltaExpediente(Expediente e, int id);
    public void BajaExpediente(int idExp, int idUser);
    public void ModificarExpediente(Expediente e, int id);
    public Expediente ConsultaPorId(int id);
}
