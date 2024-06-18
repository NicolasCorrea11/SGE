namespace SGE.Aplicacion;

public class CasoDeUsoTramiteBaja(ITramiteRepositorio repoTram, IServicioAutorizacion auth)
{
  public void Ejecutar(int id, Usuario user)
  {
    if (!auth.PoseeElPermiso(user, Permiso.TramiteBaja))
    {
      throw new AutorizacionException();
    }
    else
    {
      repoTram.BajaTramite(id);
    }
  }
}
