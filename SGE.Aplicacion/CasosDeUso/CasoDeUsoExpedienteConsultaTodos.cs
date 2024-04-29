using System.Data.Common;

namespace SGE.Aplicacion;

public class CasoDeUsoExpedienteConsultaTodos(IExpedienteRepositorio repo)
{
    public void Ejecutar(int idExp)
    {
        repo.ConsultaTodos(idExp);
    }
}
