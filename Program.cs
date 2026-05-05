using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("=== PRUEBA ABSTRACT FACTORY ===\n");

        // Elegimos un país (cambia esto para probar)
        ConfiguracionPais fabrica = new Bolivia();

        // Crear objetos
        IVehiculo vehiculo = fabrica.CrearVehiculo();
        IAlmacen almacen = fabrica.CrearAlmacen();
        IEtiqueta etiqueta = fabrica.CrearEtiqueta();

        // Mostrar resultados
        Console.WriteLine("Vehículo: " + vehiculo.Describir());
        Console.WriteLine("Almacén: " + almacen.Describir());
        Console.WriteLine("Etiqueta: " + etiqueta.Describir());

        Console.WriteLine("\n✔ Todos pertenecen al mismo país");
    }
}