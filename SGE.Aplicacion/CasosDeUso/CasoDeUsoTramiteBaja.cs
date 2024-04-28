namespace SGE.Aplicacion;

public class CasoDeUsoTramiteBaja(ITramiteRepositorio repo)
{
    public void Ejecutar(int idTram, int IdUser)
    {
        repo.TramiteBaja(idTram, IdUser);
    }
}
