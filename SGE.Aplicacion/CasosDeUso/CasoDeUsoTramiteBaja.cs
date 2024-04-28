namespace SGE.Aplicacion;

public class CasoDeUsoTramiteBaja(ITramiteRepositorio repo)
{
    public void Ejecutar(int idTram, int IdUser)
    {
        ServicioAutorizacionProvisiorio val = new();
        if (val.PoseeElPermiso(IdUser, Permiso.TramiteBaja))
        {
            repo.BajaTramite(idTram);
        }
        else
        {
            throw new AutorizacionException("No se tienen los permisos necesarios");
        }
        
    }
}
