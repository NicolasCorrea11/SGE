namespace SGE.Aplicacion;

public class CasoDeUsoExpedienteBaja(IExpedienteRepositorio repo, ServicioAutorizacionProvisiorio auth)
{
    public void Ejecutar(int id, int idUser)
    {
        if (!auth.PoseeElPermiso(idUser, Permiso.ExpedienteBaja))
        {
            throw new AutorizacionException("No se tienen los permisos necesarios");
        }   
        else
        {
            repo.BajaExpediente(id);
        }
    }
}
