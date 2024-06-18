namespace SGE.Aplicacion;

public class CasoDeUsoConsultaUsuarioId(IUsuarioRepositorio urep)
{
    public Usuario Ejecutar(int id)
    {
        Usuario? user = urep.ConsultaPorId(id);
        if (user == null)
        {
            throw new UsuarioException("");
        }
        else
        {
            return user;
        }
    }
}
