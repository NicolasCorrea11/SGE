namespace SGE.Aplicacion;

public class TramiteValidador
{
    public bool esValido(Tramite t)
    {
        if (t.Contenido != "" && t.IdUltMod > 0)
        {
            return true;
        }
        else 
        {
            return false;
        }
    }
}
