namespace SGE.Aplicacion;

public class CasoDeUsoExpedienteModificacion(IExpedienteRepositorio repo, IServicioAutorizacion auth, ExpedienteValidador validador)
{
    public void Ejecutar(Expediente e, Usuario user)
    {
        if (!auth.PoseeElPermiso(user, Permiso.ExpedienteModificacion))
        {
            throw new AutorizacionException();
        }
        else
        {
            e.IdUser = user.Id;
            if (!validador.EsValido(e, out string msg))
            {
                throw new ValidacionException(msg);
            }
            else
            {
                e.FechayHoraMod = DateTime.Now;
                repo.ModificarExpediente(e);
            }
        }
    }
}
