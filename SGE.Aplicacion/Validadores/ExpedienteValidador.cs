namespace SGE.Aplicacion;

public class ExpedienteValidador
{
    public bool EsValido(Expediente e, out string msg)
    {
        msg = "";
        if (string.IsNullOrWhiteSpace(e.Caratula))
        {
            msg += "La caratula no puede estar vacia \n";
        }
        if (e.IdUser <= 0)
        {
            msg += "Id de usuario invalido \n";
        }
        return msg == "";
    }
}
