namespace SGE.Aplicacion;

public class CasoDeUsoLogin(IUsuarioRepositorio repoUser)
{
    public Usuario? Ejecutar(string email, string contraseña)
    {
<<<<<<< HEAD
        return repoUser.InicioSesion(email, contraseña);
=======
        Usuario? user = urep.InicioSesion(email, contraseña);
        if (user != null)
        {
            return user;
        }
        else{
            throw new UsuarioException("Usuario no existe");
        }
>>>>>>> ca588a10249609ca6e8dec06fdccdb7acbb96f76
    }
}
