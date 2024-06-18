namespace SGE.Aplicacion;

public class CasoDeUsoExpedienteModificacion(IExpedienteRepositorio repo, IServicioAutorizacion auth)
{
    public void Ejecutar(Expediente e, Usuario user)
    {
        if (!auth.PoseeElPermiso(user, Permiso.ExpedienteModificacion))
        {
            throw new AutorizacionException();
        }
        else
        {
            repo.ModificarExpediente(e, user.Id);
        }
    }
}
