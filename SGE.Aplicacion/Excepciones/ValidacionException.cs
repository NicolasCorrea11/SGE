namespace SGE.Aplicacion;

public class ValidacionException: Exception
{
    public ValidacionException(string msg): base(msg) {}
    //"La entidad no cumple con los requisitos exigidos";
}
