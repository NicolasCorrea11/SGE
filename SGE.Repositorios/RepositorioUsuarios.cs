using System.Runtime.Intrinsics.Arm;
using System.Security.Cryptography;
using System.Text;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SGE.Aplicacion;

namespace SGE.Repositorios;

public class RepositorioUsuarios : IUsuarioRepositorio
{
    public void Signup(Usuario u)
    {
        using var context = new BaseContext();
        context.Usuarios.Add(u);
        context.SaveChanges();
    }

    public void EliminarUsuario(int id)
    {
        using var context = new BaseContext();
        Usuario user = context.Usuarios.Where(x => x.Id == id).SingleOrDefault();
        context.Usuarios.Remove(user);
        context.SaveChanges();
    }

    public Usuario? Login(string email, string pass)
    {
        using var context = new BaseContext();
        Usuario? user = context.Usuarios.Where(u => u.Email == email && u.Contraseña == pass).SingleOrDefault();
        if (user != null)
        {
            return user;
        }
        return null;
    }

    public void ModificarUsuario(Usuario nuevoU)
    {
        using var context = new BaseContext();
        var user = context.Usuarios.Where(u => u.Id == nuevoU.Id).SingleOrDefault();
        if (user != null)
        {
            user.Apellido = nuevoU.Apellido;
            user.Nombre = nuevoU.Nombre;
            user.Email = nuevoU.Email;
        }
        context.SaveChanges();
    }

    public Usuario? ConsultaPorId(int id)
    {
        using var context = new BaseContext();
        return context.Usuarios.Where(u => u.Id == id).SingleOrDefault();

    }

    public List<Usuario> ListarUsuarios()
    {
        using var context = new BaseContext();
        return context.Usuarios.ToList();
    }

    public void OtorgarPermiso(int id, Permiso p)
    {
        using var context = new BaseContext();
        Usuario? user = context.Usuarios.Where(u => u.Id == id).SingleOrDefault();
        if (user != null)
        {
            user.Permisos.Add(p);
        }
        context.SaveChanges();
    }

    public void QuitarPermiso(int id, Permiso p)
    {
        using var context = new BaseContext();
        Usuario? user = context.Usuarios.Where(u => u.Id == id).SingleOrDefault();
        if (user != null)
        {
            user.Permisos.Remove(p);
        }
        context.SaveChanges();
    }
}
