public class OperadorCampo : IOperador
{
    private string nombre;

    public  OperadorCampo(string nombre)
    {
        this.nombre = nombre;
    }

    public void Actualizar(string mensaje)
    {
        Console.WriteLine($"Operador de campo {nombre} recibió: {mensaje}");
    }
}