

//PRUEBAS COMPOSITE
using LogisticaPatrones.Logic.Composite;

var tramo1 = new TramaDirecta("A-B", 100, 2);
var tramo2 = new TramaDirecta("B-C", 150, 3);
var tramo3 = new TramaDirecta("C-D", 80, 1.5);

var rutaPrincipal = new RutaCompuesta("Ruta Principal");
rutaPrincipal.AñadirTramo(tramo1);
rutaPrincipal.AñadirTramo(tramo2);

var rutaSecundaria = new RutaCompuesta("Ruta Secundaria");
rutaSecundaria.AñadirTramo(tramo3); 
rutaPrincipal.AñadirTramo(rutaSecundaria);

Console.WriteLine($"Ruta: {rutaPrincipal.Nombre}");
Console.WriteLine("Costo total: " + rutaPrincipal.CalcularCosto());
Console.WriteLine("Tiempo total: " + rutaPrincipal.CalcularTiempo());
