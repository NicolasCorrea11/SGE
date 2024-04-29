namespace SGE.Aplicacion;

public class AutorizacionException : Exception 
{
    public AutorizacionException(string msg): base(msg) {}
    //"No se tienen los permisos necesarios";
}
