namespace SGE.Aplicacion;

public class Tramite
{
    public int Id {set;get;}
    public string? Caratula {set;get;}
    public DateTime FechayHoraCr {set;get;}
    public DateTime FechayHoraMod {set;get;}
    public int IdUltMod {set;get;}
    public EstadoExpediente Estado {set;get;}
}
