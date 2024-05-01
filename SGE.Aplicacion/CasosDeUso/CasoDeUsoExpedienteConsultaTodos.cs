using System.Data.Common;

namespace SGE.Aplicacion;

public class CasoDeUsoExpedienteConsultaTodos(IExpedienteRepositorio repo, RepositorioExpValidador validador)
{
    public List<object> Ejecutar(int idExp)
    {
        if (!validador.EsValido(idExp, out string msg))
        {
            throw new RepositorioException(msg);
        }
        else
        {
            return repo.ConsultaTodos(idExp);
        }
    }
}
