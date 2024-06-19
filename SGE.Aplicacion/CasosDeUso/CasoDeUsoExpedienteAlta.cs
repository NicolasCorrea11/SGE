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
            e.IdUser = user.Id;
            if (!validador.EsValido(e, out string msg))
            {
                throw new ValidacionException(msg);
            }
            else
            {
<<<<<<< HEAD
=======
                e.FechayHoraCr = DateTime.Now;
                e.FechayHoraMod = DateTime.Now;
>>>>>>> bb506e2970fe358b164923c4334190b5adf84293
                repo.AltaExpediente(e);
            }
        }
    }
}
