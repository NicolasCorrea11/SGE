namespace SGE.Aplicacion;

public class Usuario
{
    public int Id {get; set;}
    public string? Nombre {get; set;}
    public string? Apellido {get; set;}
    public string? Email {get; set;}
    public string? Contraseña {get; set;}
    public bool[]? Permisos {get; set;} = new bool[6];
}
