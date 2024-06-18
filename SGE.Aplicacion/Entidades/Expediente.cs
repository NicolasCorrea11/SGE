namespace SGE.Aplicacion;

public class Expediente
{
    public int Id {set;get;}
    public string Caratula {set;get;} = "";
    public DateTime FechayHoraCr {set;get;}
    public DateTime FechayHoraMod {set;get;}
    public int IdUser {set;get;}
    public EstadoExpediente? Estado {set;get;}

    public override string ToString()
        => $"ID = {Id}, caratula = {Caratula}, fecha y hora de creacion = {FechayHoraCr}, fecha y hora de modificacion = {FechayHoraMod}, ID de ultimo usuario en modificar = {IdUser}, estado = {Estado}";
}
