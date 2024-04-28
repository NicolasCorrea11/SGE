namespace SGE.Aplicacion;

public class CasoDeUsoBajaExpediente(IExpedienteRepositorio repo)
{
    public void Ejecutar(int id)
    {
        repo.BajaExpediente(id);
    }
}
