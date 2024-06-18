namespace SGE.Aplicacion;

public class CasoDeUsoConsultaUsuarioId(IUsuarioRepositorio repoUser)
{
    public Usuario Ejecutar(int id)
    {
        Usuario? user = repoUser.ConsultaPorId(id);
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
