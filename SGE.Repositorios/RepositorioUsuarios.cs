﻿using System.Runtime.Intrinsics.Arm;
using System.Security.Cryptography;
using System.Text;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SGE.Aplicacion;

namespace SGE.Repositorios;

public class RepositorioUsuarios: IUsuarioRepositorio
{
    public void AltaUsuario(Usuario u)
    {
        using var context = new BaseContext();
        {
            using SHA256 mySHA = SHA256.Create();
            byte[] bytes = mySHA.ComputeHash(Encoding.UTF8.GetBytes(u.Contraseña));
            var sb = new StringBuilder();
            for (int i=0;i<bytes.Length;i++)
            {
                sb.Append(bytes[i].ToString());
            }
            string pass = sb.ToString();
            u.Contraseña = pass;
            context.Usuarios.Add(u);
            context.SaveChanges();
        }
    }

    public Usuario? InicioSesion(string email, string contraseña)
    {
        using var context = new BaseContext();
        {
            using SHA256 mySHA = SHA256.Create();
            byte[] bytes = mySHA.ComputeHash(Encoding.UTF8.GetBytes(contraseña));
            var sb = new StringBuilder();
            for (int i=0;i<bytes.Length;i++)
            {
                sb.Append(bytes[i].ToString());
            }
            string pass = sb.ToString();
            Usuario? user = context.Usuarios.Where(x => x.Email == email && x.Contraseña == pass).SingleOrDefault();
            if (user != null)
                return user;
            else
                return null;
        }
    }

    public Usuario? ConsultaPorId(int id)
    {
        Usuario? dev = new Usuario();
        using var context = new BaseContext();
        {
            dev = context.Usuarios.Where(x => x.Id == id).SingleOrDefault();
        }
        return dev;

    }

    public List<Usuario> ListarUsuarios()
    {
        using var context = new BaseContext();
        {
            return context.Usuarios.ToList();
        }
    }

    public void DarPermiso(int id, Permiso p)
    {
        using var context = new BaseContext();
        {
            Usuario? user = context.Usuarios.Where(x => x.Id == id).SingleOrDefault();
            user.Permisos[(int)p] = true;
            context.SaveChanges();
        }
    }
}