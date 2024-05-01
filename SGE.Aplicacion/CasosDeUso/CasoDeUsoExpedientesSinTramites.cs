namespace SGE.Aplicacion;

public class CasoDeUsoExpedientesSinTramites(IExpedienteRepositorio repo)
{
    public List<Expediente> Ejecutar()
    {
        List<Expediente> lis = repo.ListarExpedientes();
        if (lis.Count == 0)
        {
            throw new RepositorioException("La entidad que se intenta eliminar, modificar o acceder no existe en el repositorio");
        }
        else
        {
            return repo.ListarExpedientes();
        }
    }
}
