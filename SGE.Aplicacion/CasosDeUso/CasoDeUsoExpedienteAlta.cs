namespace SGE.Aplicacion;

public class CasoDeUsoExpedienteAlta(IExpedienteRepositorio repo)
{
    public void Ejecutar(Expediente e, int idUser)
    {   
        ServicioAutorizacionProvisiorio val = new();
        if (val.PoseeElPermiso(idUser, Permiso.ExpedienteAlta))
        {
            string mensajeError;
            ExpedienteValidador valid = new();
            if (valid.esValido(e, out mensajeError))
            {
                e.FechayHoraCr = DateTime.Now;
                e.FechayHoraMod = DateTime.Now;
                repo.AltaExpediente(e, idUser);
            }
            else
            {
                throw new ValidacionException(mensajeError);
            }
        }
        else 
        {
            throw new AutorizacionException("No se tienen los permisos necesarios");
        }
    }
}
