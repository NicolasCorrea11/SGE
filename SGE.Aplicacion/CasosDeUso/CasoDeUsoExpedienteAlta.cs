namespace SGE.Aplicacion;

public class CasoDeUsoExpedienteAlta(IExpedienteRepositorio repo, IServicioAutorizacion auth, ExpedienteValidador validador)
{
    public void Ejecutar(Expediente e, Usuario user)
    {
        e.FechayHoraCr = DateTime.Now;
        e.FechayHoraMod = DateTime.Now;
        e.IdUser = user.Id;
        if (!auth.PoseeElPermiso(user, Permiso.ExpedienteAlta))
        {
            throw new AutorizacionException();
        }
        else
        {
            if (!validador.EsValido(e, out string msg))
            {
                throw new ValidacionException(msg);
            }
            else
            {
                repo.AltaExpediente(e);
            }
        }
    }
}
