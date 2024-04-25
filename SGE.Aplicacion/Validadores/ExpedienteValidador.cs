namespace SGE.Aplicacion;

public class ExpedienteValidador
{
    public bool esValido(Expediente e)
    {
        if (e.Caratula != "" && e.IdUltMod > 0)
        {
            return true;
        }
        else 
        {
            return false;
        }
    }
}
