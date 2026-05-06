public class Supervisor : IOperador
{
    private string nombre = "Supervisor General"; // Puedes asignar un nombre por defecto o pasarlo por el constructor

    public Supervisor(IOrdenBuilder builder, CreadorEnvio creador, ConfiguracionPais paisCfg) :base(builder, creador, paisCfg)
    {
    }

    public override void Actualizar(string mensaje)
    {
        Console.WriteLine($"Supervisor {nombre} recibió: {mensaje}");
    }
}
