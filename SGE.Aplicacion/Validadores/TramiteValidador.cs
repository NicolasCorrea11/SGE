namespace SGE.Aplicacion;

public class TramiteValidador
{
    public bool esValido(Tramite t, out string msg)
    {
        msg = "";
        if (string.IsNullOrWhiteSpace(t.Contenido))
        {
            msg += "El contenido no puede ser vacio \n";
        }
        if (t.IdUser <= 0)
        {
            msg += "Id de usuario no valido \n";
        }
        return msg == "";
    }
}
