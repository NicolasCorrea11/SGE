namespace SGE.Aplicacion;

public class CasoDeUsoSignup(IUsuarioRepositorio urep)
{
    public void Ejecutar(Usuario user)
    {
        urep.AltaUsuario(user);
    }
}
