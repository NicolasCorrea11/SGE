namespace SGE.Aplicacion;

public class CasoDeUsoExpedienteBaja(IExpedienteRepositorio repo)
{
    public void Ejecutar(int idExp, int idUser)
    {
        repo.BajaExpediente(idExp, idUser);
    }
}
