namespace SGE.Aplicacion;
public interface IExpedienteRepositorio
{
    public void AltaExpediente(Expediente e, int idUser);
    public void BajaExpediente(int idExp);
    public void ModificarExpediente(Expediente e, int idUser);
    public Expediente? ConsultaPorId(int id);
    public List<object> ConsultaTodos(int idExp);
    public List<Expediente> ListarExpedientes();
}
