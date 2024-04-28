namespace SGE.Aplicacion;

public class ExpedienteValidador
{
    public bool esValido(Expediente e, out string mensajeError)
    {
        mensajeError = "";
        if (string.IsNullOrWhiteSpace(e.Caratula))
        {
            mensajeError += "La caratula no puede estar vacia \n";
        }
        if (e.IdUltMod <= 0)
        {
            mensajeError += "Id de usuario invalido \n";
        }
        return mensajeError == "";
    }
}
