namespace SGE.Aplicacion;
public interface IExpedienteRepositorio
{
    public void AltaExpediente(Expediente e, int IdUser);
    public void BajaExpediente(int idExp, int idUser);
}
