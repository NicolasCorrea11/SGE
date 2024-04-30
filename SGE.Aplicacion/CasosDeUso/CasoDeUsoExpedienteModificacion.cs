namespace SGE.Aplicacion;

public class CasoDeUsoExpedienteModificacion(IExpedienteRepositorio repo, IServicioAutorizacion auth, RepositorioExpValidador validador)
{
    public void Ejecutar(Expediente e, int idUser) 
    {
        if (!auth.PoseeElPermiso(idUser, Permiso.ExpedienteModificacion))
        {
            throw new AutorizacionException("No se tienen los permisos necesarios");
        }
        else
        {
            if (!validador.EsValido(e.Id, out string msg))
            {
                throw new RepositorioException(msg);
            }
            else
            {
                repo.ModificarExpediente(e, idUser);
            }
        }
    }
}
