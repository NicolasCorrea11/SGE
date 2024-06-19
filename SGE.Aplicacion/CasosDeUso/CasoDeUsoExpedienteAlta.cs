namespace SGE.Aplicacion;

public class CasoDeUsoExpedienteAlta(IExpedienteRepositorio repo, IServicioAutorizacion auth, ExpedienteValidador validador)
{
    public void Ejecutar(Expediente e, Usuario user)
    {
        if (!auth.PoseeElPermiso(user, Permiso.ExpedienteAlta))
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
                e.FechayHoraCr = DateTime.Now;
                e.FechayHoraMod = DateTime.Now;
                repo.AltaExpediente(e);
            }
        }
    }
}
