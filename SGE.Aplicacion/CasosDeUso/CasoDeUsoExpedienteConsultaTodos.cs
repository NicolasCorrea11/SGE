using System.Data.Common;

namespace SGE.Aplicacion;

public class CasoDeUsoExpedienteConsultaTodos(IExpedienteRepositorio repo)
{
    public List<object> Ejecutar(int idExp)
    {
        return repo.ConsultaTodos(idExp);
    }
}
