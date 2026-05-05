using System;

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        bool salir = false;

        while (!salir)
        {
            Console.WriteLine("\n=== PRUEBA ABSTRACT FACTORY ===");
            Console.WriteLine("1. Bolivia");
            Console.WriteLine("2. Perú");
            Console.WriteLine("3. Chile");
            Console.WriteLine("0. Salir");
            Console.Write("Seleccione un país: ");

            string opcion = Console.ReadLine();
            ConfiguracionPais fabrica = null;

            switch (opcion)
            {
                case "1":
                    fabrica = new Bolivia();
                    break;

                case "2":
                    fabrica = new Peru();
                    break;

                case "3":
                    fabrica = new Chile();
                    break;

                case "0":
                    salir = true;
                    continue;

                default:
                    Console.WriteLine("Opción inválida.");
                    continue;
            }

            // 🔥 Aquí se prueba el patrón
            IVehiculo vehiculo = fabrica.CrearVehiculo();
            IAlmacen almacen = fabrica.CrearAlmacen();
            IEtiqueta etiqueta = fabrica.CrearEtiqueta();

            Console.WriteLine("\n--- CONFIGURACIÓN GENERADA ---");
            Console.WriteLine("Vehículo: " + vehiculo.Describir());
            Console.WriteLine("Almacén: " + almacen.Describir());
            Console.WriteLine("Etiqueta: " + etiqueta.Describir());

            Console.WriteLine("\n✔ Todos los elementos pertenecen al mismo país");
        }
    }
}