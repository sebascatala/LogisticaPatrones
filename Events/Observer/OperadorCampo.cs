public abstract class OperadorCampo : IOperador
{
    // protected permite que las clases hijas (como Supervisor) accedan a esta variable
    protected string nombre ="operador de campo"; 
    // El constructor DEBE asignar los valores a las variables
    protected OperadorCampo(IOrdenBuilder builder, CreadorEnvio creador, ConfiguracionPais paisCfg): base(builder, creador, paisCfg)
    {
    }
    // Asegúrate de que IOperador tenga el método Actualizar como virtual o abstract
    public override void Actualizar(string mensaje)
    {
        Console.WriteLine($"Operador de campo {nombre} recibió: {mensaje}");
    }
}