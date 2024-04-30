namespace SGE.Aplicacion;

public class CasoDeUsoExpedienteBaja(IExpedienteRepositorio repo, IServicioAutorizacion auth, RepositorioExpValidador validador)
{
    public void Ejecutar(int id, int idUser)
    {
        if (!auth.PoseeElPermiso(idUser, Permiso.ExpedienteBaja))
        {
            throw new AutorizacionException("No se tienen los permisos necesarios");
        }   
        else
        {
            if (!validador.EsValido(id, out string msg))
            {
                throw new RepositorioException(msg);
            }
            else
            {
                repo.BajaExpediente(id);
            }
        }
    }
}
