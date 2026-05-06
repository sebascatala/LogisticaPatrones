public class Director : ManejadorIncidencia
{
    private IOrdenBuilder _builder;
    private CreadorEnvio _creador;      // Asociación con Factory Method
    private ConfiguracionPais _paisCfg; // Asociación con Abstract Factory

    public Director(IOrdenBuilder builder, CreadorEnvio creador, ConfiguracionPais paisCfg)
    {
        _builder = builder;
        _creador = creador;
        _paisCfg = paisCfg;
    }

    public override void Manejar(Incidencia incidencia)
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

    public void generarOrden()
    {
        Console.WriteLine("--- Director: Generando Solución Logística Integral ---");

        // 1. Uso de Abstract Factory: Configurar infraestructura local
        _paisCfg.CrearVehiculo();
        _paisCfg.CrearAlmacen();
        _paisCfg.CrearEtiqueta();
        Console.WriteLine(" > Configurada infraestructura local.");

        // 2. Uso de Factory Method: Crear el objeto de envío específico
        Envio elEnvio = _creador.CrearEnvio();
        Console.WriteLine($" > Envío de tipo {elEnvio.GetType().Name} preparado.");

        // 3. Uso de Builder: Construir la orden final uniendo todo
        _builder.generarId();
        _builder.añadirDescripcion();
        _builder.añadirSeguroTransito();
        
        OrdenDespacho orden = _builder.obtenerOrden();
        
        Console.WriteLine($"### Orden {orden.id} despachada con éxito.");
    }
}