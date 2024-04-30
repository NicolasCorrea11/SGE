namespace SGE.Aplicacion;

public class CasoDeUsoExpedienteAlta(IExpedienteRepositorio repo, IServicioAutorizacion auth, ExpedienteValidador validador)
{
    public void Ejecutar(Expediente e, int idUser)
    {   
        if (!auth.PoseeElPermiso(idUser, Permiso.ExpedienteAlta))
        {
            throw new AutorizacionException("No se tienen los permisos necesarios");
        }
        else 
        {
            e.IdUser = idUser;
            if (!validador.EsValido(e, out string msg))
            {
                throw new ValidacionException(msg);
            }
            else
            {
                e.FechayHoraCr = DateTime.Now;
                e.FechayHoraMod = DateTime.Now;
                repo.AltaExpediente(e);
            }
        }
    }
}
