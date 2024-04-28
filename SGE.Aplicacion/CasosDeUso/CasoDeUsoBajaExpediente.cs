namespace SGE.Aplicacion;

public class CasoDeUsoBajaExpediente(IExpedienteRepositorio repo)
{
    public void Ejecutar(int idExp, int idUser)
    {
        repo.BajaExpediente(idExp, idUser);
    }
}
