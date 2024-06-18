namespace SGE.Aplicacion;

public class CasoDeUsoConsultaExpedienteId(IExpedienteRepositorio repo)
{
    public Expediente Ejecutar(int id)
    {
        Expediente? exp = repo.ConsultaPorId(id);
        if (exp != null)
        {
            return exp;
        }
        else
        {
            throw new RepositorioException("El expediente no existe");
        }
    }
}
