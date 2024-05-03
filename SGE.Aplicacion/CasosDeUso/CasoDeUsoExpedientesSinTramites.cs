namespace SGE.Aplicacion;

public class CasoDeUsoExpedientesSinTramites(IExpedienteRepositorio repo)
{
    public List<Expediente> Ejecutar()
    {
        List<Expediente> lista = repo.ListarExpedientes();
        if (lista.Count == 0)
        {
            throw new RepositorioException("La entidad que se intenta eliminar, modificar o acceder no existe en el repositorio");
        }
        else
        {
            return lista;
        }
    }
}
