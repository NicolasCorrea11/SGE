namespace SGE.Aplicacion;

public class CasoDeUsoTramiteBaja(ITramiteRepositorio repo, IServicioAutorizacion auth, IServicioActualizacionEstado act, RepositorioTramiteValidador validador)
{
    public void Ejecutar(int id, int idUser)
    {
        if (!auth.PoseeElPermiso(idUser, Permiso.TramiteBaja))
        {
            throw new AutorizacionException("No se tienen los permisos necesarios");
        }
        else
        {
            if (!validador.EsValido(id, out string msg))
            {
                throw new RepositorioException(msg);
            }
            else
            {
                Tramite? t = repo.ConsultaPorId(id);
                repo.BajaTramite(id);
                act.ActualizarEstado(t.ExpedienteId);
            }
        }
    }
}
