namespace SGE.Aplicacion;

public class CasoDeUsoExpedienteConsultaTodos(IExpedienteRepositorio repo)
{
    public List<object> Ejecutar(int id)
    {  
        List<object> dev = repo.ConsultaTodos(id);
        if (dev.Count == 0)
        {
            throw new RepositorioException("El expediente no existe");
        }
        else
        {
            return dev;
        }
    }
}
