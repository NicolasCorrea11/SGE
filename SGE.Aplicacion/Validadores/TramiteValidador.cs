namespace SGE.Aplicacion;

public class TramiteValidador
{
    public bool esValido(Tramite t, out string mensajeError)
    {
        mensajeError = "";
        if (string.IsNullOrWhiteSpace(t.Contenido))
        {
            mensajeError += "El contenido no puede ser vacio";
        }
        if (t.IdUltMod <= 0)
        {
            mensajeError += "Id de usuario no valido \n";
        }
        return mensajeError == "";
    }
}
