namespace SGE.Aplicacion;

public class CasoDeUsoExpedienteBaja(IExpedienteRepositorio repo)
{
    public void Ejecutar(int idExp, int idUser)
    {
        ServicioAutorizacionProvisiorio val = new();
        if (val.PoseeElPermiso(idUser, Permiso.ExpedienteBaja))
        {
            repo.BajaExpediente(idExp);
        }   
        else
        {
            throw new AutorizacionException("No se tienen los permisos necesarios");
        }
    }
}
