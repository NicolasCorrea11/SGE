using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;

namespace SGE.Aplicacion;

public class ServicioHash: IServicioHash
{
    public string HashingPass(string pw)
    {
        using SHA256 mySHA = SHA256.Create();
        byte[] bytes = mySHA.ComputeHash(Encoding.UTF8.GetBytes(pw));
        var sb = new StringBuilder();
        for (int i = 0; i < bytes.Length; i++)
        {
            sb.Append(bytes[i].ToString());
        }
        return sb.ToString();
    }
}
