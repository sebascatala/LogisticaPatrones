public class Director : ManejadorIncidencia
{
    public Director(IOrdenBuilder builder, CreadorEnvio creador, ConfiguracionPais paisCfg) : base(builder, creador, paisCfg)
    {
    }

    public override void Actualizar(string mensaje)
    {
        Console.WriteLine($"Director recibido actualización: {mensaje}");
    }

    public void generarOrden()
    {
        if (incidencia.Nivel >= 3)
        {
            Console.WriteLine("Director: Nivel crítico. Ejecutando protocolos de creación...");
            generarOrden();
        }
        else
        {
            siguiente?.Manejar(incidencia);
        }
    }


}