namespace SGE.Aplicacion;

public class CasoDeUsoExpedienteListar(IExpedienteRepositorio repo)
{
    public List<Expediente> Ejecutar()
    {
        return repo.ListarExpedientes();
    }
}
