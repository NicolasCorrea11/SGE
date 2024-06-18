namespace SGE.Aplicacion;

public class CasoDeUsoConsultaUsuarioId(IUsuarioRepositorio urep)
{
    public Usuario? Ejecutar(int id)
    {
        return urep.ConsultaPorId(id);
    }
}
