namespace SGE.Aplicacion;

public class Expediente
{
    public int Id { get; set; }
    public string Caratula { get; set; } = "";
    public EstadoExpediente? Estado { get; set; }
    public DateTime FechayHoraCr { get; set; }
    public DateTime FechayHoraMod { get; set; }
    public int IdUser { get; set; }
    public List<Tramite> Tramites { get; set; } = [];

    public override string ToString()
        => $"ID = {Id}, caratula = {Caratula}, fecha y hora de creacion = {FechayHoraCr}, fecha y hora de modificacion = {FechayHoraMod}, ID de ultimo usuario en modificar = {IdUser}, estado = {Estado}";
}
