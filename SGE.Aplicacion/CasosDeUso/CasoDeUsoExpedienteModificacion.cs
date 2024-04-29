namespace SGE.Aplicacion;

public class CasoDeUsoExpedienteModificacion(IExpedienteRepositorio repo)
{
    public void Ejecutar(Expediente e, int idUser) 
    {
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
        {
            throw new AutorizacionException("No se tienen los permisos necesarios");
        }
    }
}
