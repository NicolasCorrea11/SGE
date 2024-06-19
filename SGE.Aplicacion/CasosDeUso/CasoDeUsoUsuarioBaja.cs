namespace SGE.Aplicacion;

public class CasoDeUsoUsuarioBaja(IUsuarioRepositorio urep)
{
    public void Ejecutar(int id)
    {
        urep.BajaUsuario(id);
    }
}
