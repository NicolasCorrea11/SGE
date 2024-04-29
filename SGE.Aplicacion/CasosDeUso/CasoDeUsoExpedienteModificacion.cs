namespace SGE.Aplicacion;

public class CasoDeUsoExpedienteModificacion(IExpedienteRepositorio repo, ServicioAutorizacionProvisiorio auth)
{
    public void Ejecutar(Expediente e, int idUser) 
    {
<<<<<<< HEAD
        ServicioAutorizacionProvisiorio val = new();
        if (val.PoseeElPermiso(idUser, Permiso.ExpedienteModificacion))
        {
            string mensajeError;
            ExpedienteValidador valid = new();
            if (valid.esValido(e, out mensajeError))
            {
                e.FechayHoraMod = DateTime.Now;
                repo.ModificarExpediente(e, idUser);
            }
            else
            {
                throw new ValidacionException(mensajeError);
            }
        }
        else
=======
        if (!auth.PoseeElPermiso(idUser, Permiso.ExpedienteModificacion))
>>>>>>> c987ec2c7c698de088ef621f5e5b04f0d1ee06bc
        {
            throw new AutorizacionException("No se tienen los permisos necesarios");
        }
        else
        {
            repo.ModificarExpediente(e, idUser);
        }
    }
}
