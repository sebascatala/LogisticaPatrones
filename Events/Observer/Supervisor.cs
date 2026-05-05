public class Supervisor:IOperador
{
    private string nombre;

    public  Supervisor(string nombre)
    {
        this.nombre = nombre;
    }

    public void Actualizar(string mensaje)
    {
        Console.WriteLine($"Supervisor {nombre} recibió: {mensaje}");
    }
}