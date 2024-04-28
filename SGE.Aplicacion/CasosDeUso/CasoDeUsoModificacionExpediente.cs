namespace SGE.Aplicacion;

public class CasoDeUsoModificacionExpediente(IExpedienteRepositorio repo)
{
    public void Ejecutar(Expediente e,int IdUser) 
    {
        repo.ModificarExpediente(e, idUser);
    }
}
