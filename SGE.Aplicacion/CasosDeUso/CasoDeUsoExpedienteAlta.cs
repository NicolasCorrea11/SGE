namespace SGE.Aplicacion;

public class CasoDeUsoExpedienteAlta(IExpedienteRepositorio repo, ServicioAutorizacionProvisiorio auth)
{
    public void Ejecutar(Expediente e, int idUser)
    {   
        if (!auth.PoseeElPermiso(idUser, Permiso.ExpedienteAlta))
        {
            throw new AutorizacionException("No se tienen los permisos necesarios");
        }
        else 
        {
            e.FechayHoraCr = DateTime.Now;
            e.FechayHoraMod = DateTime.Now;
            repo.AltaExpediente(e, idUser);
        }
    }
}
