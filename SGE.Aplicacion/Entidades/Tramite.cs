namespace SGE.Aplicacion;

public class Tramite
{
    public int Id {set;get;}
    public int ExpedienteId {set;get;}
    public EtiquetaTramite Etiqueta {set;get;}
    public string? Contenido {set;get;}
    public DateTime FechayHoraCr {set;get;}
    public DateTime FechayHoraMod {set;get;}
    public int IdUltMod {set;get;}
}
