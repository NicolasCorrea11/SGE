namespace SGE.Aplicacion;

public class CasoDeUsoConsultaUsuarioId(IUsuarioRepositorio repoUser)
{
    public Usuario Ejecutar(int id)
    {
<<<<<<< HEAD
        return repoUser.ConsultaPorId(id);
=======
        Usuario? user = urep.ConsultaPorId(id);
        if (user == null)
        {
            throw new UsuarioException("");
        }
        else
        {
            return user;
        }
>>>>>>> ca588a10249609ca6e8dec06fdccdb7acbb96f76
    }
}
