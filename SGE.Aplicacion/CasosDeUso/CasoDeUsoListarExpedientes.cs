namespace SGE.Aplicacion;

public class CasoDeUsoListarExpedientes(IExpedienteRepositorio repo)
{
    public List<Expediente> Ejecutar()
    {
        return repo.ListarExpedientes();
    }
}
