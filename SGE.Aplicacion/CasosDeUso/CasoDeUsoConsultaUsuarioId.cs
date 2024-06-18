namespace SGE.Aplicacion;

public class CasoDeUsoConsultaUsuarioId(IUsuarioRepositorio repoUser)
{
    public Usuario? Ejecutar(int id)
    {
        return repoUser.ConsultaPorId(id);
    }
}
