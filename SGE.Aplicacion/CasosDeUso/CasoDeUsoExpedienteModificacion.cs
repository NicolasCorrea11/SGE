namespace SGE.Aplicacion;

public class CasoDeUsoExpedienteModificacion(IExpedienteRepositorio repo, ServicioAutorizacionProvisiorio auth)
{
    public void Ejecutar(Expediente e, int idUser) 
    {
        if (!auth.PoseeElPermiso(idUser, Permiso.ExpedienteModificacion))
        {
            throw new AutorizacionException("No se tienen los permisos necesarios");
        }
        else
        {
            repo.ModificarExpediente(e, idUser);
        }
    }
}
