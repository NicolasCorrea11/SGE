namespace SGE.Aplicacion;

public class AutorizacionException : Exception 
{
    public AutorizacionException(string msg = "No se tienen los permisos necesarios"): base(msg) {}
    //"No se tienen los permisos necesarios";
}
