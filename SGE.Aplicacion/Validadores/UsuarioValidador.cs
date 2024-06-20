namespace SGE.Aplicacion;

public class UsuarioValidador
{
    public bool EsValido(Usuario user, out string msg)
    {
        msg = "";
        if (user.Nombre == "")
        {
            msg += "El nombre no puede estar vacio  |||\n";
        }
        if (user.Apellido == "")
        {
            msg += "El apellido no puede estar vacio |||\n";
        }
        if (user.Email == "")
        {
            msg += "El Email no puede ser vacio |||\n";
        }
        if (user.Contraseña == "")
        {
            msg += "La contraseña no puede ser vacia";
        }
        return msg == "";
    }

}
