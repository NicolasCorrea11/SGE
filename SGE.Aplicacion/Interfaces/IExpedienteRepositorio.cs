namespace SGE.Aplicacion;
public interface IExpedienteRepositorio
{
<<<<<<< HEAD
    public void AltaExpediente(Expediente e, int id);
    public void BajaExpediente(int idExp, int idUser);
=======
    public void AltaExpediente(Expediente e, int IdUser);
    public void BajaExpediente(int IdExp, int IdUser);
>>>>>>> 53a719478aed57760779d30a10bfcaeb23935d2f
    public void ModificarExpediente(Expediente e, int id);
    public Expediente ConsultaPorId(int id);
}
