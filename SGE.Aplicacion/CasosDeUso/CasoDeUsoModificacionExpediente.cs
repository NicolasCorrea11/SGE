namespace SGE.Aplicacion;

public class CasoDeUsoModificacionExpediente(IExpedienteRepositorio repo)
{
    public void Ejecutar(Expediente e, int IdUser) 
    {
        e.FechayHoraMod = DateTime.Now;
        repo.ModificarExpediente(e, IdUser);
    }
}
