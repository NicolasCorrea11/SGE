using SGE.Aplicacion;

int b = 0;
try
{
    incr(b);
}
catch (Exception e)
{
    Console.WriteLine(e.Message);
}

void incr(int x)
{
    x++;
    if (x > 0)
    {
        throw new AutorizacionException("No se tienen los permisos necesarios");
    }
}