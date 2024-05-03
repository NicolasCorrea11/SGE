using System.Data.Common;

namespace SGE.Aplicacion;

public class CasoDeUsoExpedienteConsultaTodos(IExpedienteRepositorio repo, RepositorioExpValidador validador)
{
    public List<object> Ejecutar(int id)
    {
        if (!validador.EsValido(id, out string msg))
        {
            throw new RepositorioException(msg);
        }
        else
        {
            return repo.ConsultaTodos(id);
        }
    }
}
