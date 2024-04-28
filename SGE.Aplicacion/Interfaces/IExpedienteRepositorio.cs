namespace SGE.Aplicacion;
public interface IExpedienteRepositorio
{
<<<<<<< HEAD
    public void AltaExpediente(Expediente e);
    public void BajaExpediente(int id);
    public void ModificarExpediente(Expediente e, int id);
    public Expediente ConsultaPorId(int id);
=======
    public void AltaExpediente(Expediente e, int IdUser);
    public void BajaExpediente(int idExp, int idUser);
>>>>>>> 831b012dd6891777690c140ec9ef85131c651c69
}
