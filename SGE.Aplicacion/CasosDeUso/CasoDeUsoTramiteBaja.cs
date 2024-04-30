namespace SGE.Aplicacion;

public class CasoDeUsoTramiteBaja(ITramiteRepositorio repoTramite, IServicioAutorizacion auth, IServicioActualizacionEstado act, RepositorioTramiteValidador validador)
{
    public void Ejecutar(int id, int idUser)
    {
        if (!auth.PoseeElPermiso(idUser, Permiso.TramiteBaja))
        {
            throw new AutorizacionException("No se tienen los permisos necesarios");
        }
        else
        {
            if (!validador.EsValido(id, out string msg)) // MAL IMPLEMENTADO
            {
                throw new RepositorioException(msg);
            }
            else
            {
                int idExp = repoTramite.BajaTramite(id);
                act.ActualizarEstado(idExp);
            }
        }
    }
}
