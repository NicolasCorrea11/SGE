namespace SGE.Aplicacion;

<<<<<<< HEAD
public class CasoDeUsoExpedienteAlta(IExpedienteRepositorio repoExp)
=======
public class CasoDeUsoExpedienteAlta(IExpedienteRepositorio repo, IServicioAutorizacion auth, ExpedienteValidador validador)
>>>>>>> ca588a10249609ca6e8dec06fdccdb7acbb96f76
{
    public void Ejecutar(Expediente e, Usuario user)
    {
        string msg;
        e.FechayHoraCr = DateTime.Now;
        e.FechayHoraMod = DateTime.Now;
<<<<<<< HEAD
        repoExp.AltaExpediente(e);
=======
        e.IdUser = user.Id;
        if (!auth.PoseeElPermiso(user, Permiso.ExpedienteAlta))
        {
            throw new AutorizacionException();
        }
        else
        {
            if (!validador.EsValido(e, out msg))
            {
                throw new ValidacionException(msg);
            }
            else
            {
                repo.AltaExpediente(e);
            }
        }
>>>>>>> ca588a10249609ca6e8dec06fdccdb7acbb96f76
    }
}
