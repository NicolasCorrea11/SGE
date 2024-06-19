namespace SGE.Aplicacion;

public class CasoDeUsoUsuarioListar(IUsuarioRepositorio repoUser)
{
  public List<Usuario> Ejecutar()
  {
    return repoUser.ListarUsuarios();
  }
}
