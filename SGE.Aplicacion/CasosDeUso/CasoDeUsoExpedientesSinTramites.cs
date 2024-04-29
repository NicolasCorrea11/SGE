namespace SGE.Aplicacion;

public class CasoDeUsoExpedientesSinTramites(IExpedienteRepositorio repo)
{
    public List<Expediente> Ejecutar()
    {
        return repo.ListarExpedientes();
    }
}
