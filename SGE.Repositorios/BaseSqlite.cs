using Microsoft.EntityFrameworkCore;

namespace SGE.Repositorios;

public class BaseSqlite
{
    public static void Inicializar()
    {
        using var context = new BaseContext();
        context.Database.EnsureCreated();
        var connection = context.Database.GetDbConnection();
        connection.Open();
        using var command = connection.CreateCommand();
        command.CommandText = "PRAGMA journal_mode=DELETE;";
        command.ExecuteNonQuery();

    }
}
