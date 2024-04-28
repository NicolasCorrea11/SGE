namespace SGE.Aplicacion;

public class CasoDeUsoExpedienteModificacion(IExpedienteRepositorio repo)
{
    public void Ejecutar(Expediente e, int idUser) 
    {
        repo.ModificarExpediente(e, idUser);
    }
}
