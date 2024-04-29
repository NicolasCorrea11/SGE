namespace SGE.Aplicacion;

public class CasoDeUsoExpedienteModificacion(IExpedienteRepositorio repo)
{
    public void Ejecutar(Expediente e, int idUser) 
    {
        ServicioAutorizacionProvisiorio val = new();
        if (val.PoseeElPermiso(idUser, Permiso.ExpedienteModificacion))
        {
            repo.ModificarExpediente(e, idUser);
        }
        else
        {
            throw new AutorizacionException("No se tienen los permisos necesarios");
        }
    }
}
