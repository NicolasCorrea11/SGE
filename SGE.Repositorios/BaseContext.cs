using Microsoft.EntityFrameworkCore;
using SGE.Aplicacion;

namespace SGE.Repositorios;

public class BaseContext: DbContext
{
    public DbSet<Usuario> Usuarios {get; set;}
    public DbSet<Expediente> Expedientes {get; set;}
    public DbSet<Tramite> Tramites {get; set;}

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("data source=Base.sqlite");
    }

}