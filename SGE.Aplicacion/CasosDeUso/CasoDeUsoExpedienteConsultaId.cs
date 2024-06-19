namespace SGE.Aplicacion;

public class CasoDeUsoExpedienteConsultaId(IExpedienteRepositorio repoExp)
{
    public Expediente Ejecutar(int id)
    {
        Expediente? exp = repoExp.ConsultaPorId(id);
        if (exp == null)
        {
            throw new RepositorioException("El expediente no existe");
        }
        else
        {
            return exp;
        }
    }
}
