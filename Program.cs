Console.WriteLine("=== SISTEMA LOGÍSTICA PATRONES ===\n");

// ===============================
// FACTORY METHOD
// ===============================
Console.WriteLine("=== FACTORY METHOD ===");

CreadorEnvio creadorEstandar = new CreadorEstandar();
Envio envioEstandar = creadorEstandar.CrearEnvio();
Console.WriteLine("Envío creado: " + envioEstandar.GetType().Name);

CreadorEnvio creadorRefrigerado = new CreadorRefrigerado();
Envio envioRefrigerado = creadorRefrigerado.CrearEnvio();
Console.WriteLine("Envío creado: " + envioRefrigerado.GetType().Name);

CreadorEnvio creadorValor = new CreadorValorDeclarado();
Envio envioValor = creadorValor.CrearEnvio();
Console.WriteLine("Envío creado: " + envioValor.GetType().Name);


// ===============================
// BUILDER
// ===============================
Console.WriteLine("\n=== BUILDER ===");

IOrdenBuilder builderLocal = new OrdenLocal();
builderLocal.generarId();
builderLocal.añadirDescripcion();
builderLocal.añadirDocumentacionAduanera();
builderLocal.añadirSeguroTransito();

OrdenDespacho ordenLocal = builderLocal.obtenerOrden();

Console.WriteLine("Orden creada:");
Console.WriteLine("ID: " + ordenLocal.id);
Console.WriteLine("Descripción: " + ordenLocal.descripcion);
Console.WriteLine("Aduana: " + ordenLocal.documentacionAduana);
Console.WriteLine("Seguro: " + ordenLocal.seguroTransito);
Console.WriteLine("Orden válida: " + ordenLocal.EsValida());


// ===============================
// OBSERVER
// ===============================
Console.WriteLine("\n=== OBSERVER ===");

CentroDistribucion centro = new CentroDistribucion();

IOperador operador1 = new OperadorCampo(new OrdenLocal(), new CreadorEstandar(), new Chile());
IOperador supervisor1 = new Supervisor(new OrdenLocal(), new CreadorEstandar(), new Chile());

centro.agregarOperador(operador1);
centro.agregarOperador(supervisor1);

centro.notificarOperador("Nuevo envío registrado en el centro de distribución.");


// ===============================
// CHAIN OF RESPONSIBILITY
// ===============================
Console.WriteLine("\n=== CHAIN OF RESPONSIBILITY ===");

ConfiguracionPais configPais = new Chile(); // Usa una implementación concreta de ConfiguracionPais
ManejadorIncidencia coordinador = new Coordinador(new OrdenLocal(), new CreadorEstandar(), configPais);
ManejadorIncidencia gerente = new Gerente(new OrdenLocal(), new CreadorEstandar(), configPais);
ManejadorIncidencia director = new Director(new OrdenLocal(), new CreadorEstandar(), configPais);

coordinador.SetSiguiente(gerente);
gerente.SetSiguiente(director);

Incidencia incidencia1 = new Incidencia(1, "Retraso menor en entrega local");
Incidencia incidencia2 = new Incidencia(2, "Problema con documentación");
Incidencia incidencia3 = new Incidencia(3, "Conflicto con cliente importante");
Incidencia incidencia4 = new Incidencia(4, "Incidencia crítica internacional");

coordinador.Manejar(incidencia1);
coordinador.Manejar(incidencia2);
coordinador.Manejar(incidencia3);
coordinador.Manejar(incidencia4);

// ===============================
// COMPOSITE
// ===============================
Console.WriteLine("\n=== COMPOSITE ===");

// Creamos tramos simples (Hojas)
TramaDirecta tramo1 = new TramaDirecta("Tramo La Paz - Oruro", 150.0, 3.5);
TramaDirecta tramo2 = new TramaDirecta("Tramo Oruro - Potosí", 200.0, 4.0);

// Creamos la ruta compuesta (Composite)
RutaCompuesta rutaBolivia = new RutaCompuesta("Ruta Bolivia");
rutaBolivia.AñadirTramo(tramo1);
rutaBolivia.AñadirTramo(tramo2);

Console.WriteLine($"Ruta: {rutaBolivia.Nombre}");
Console.WriteLine($"Costo Base Acumulado: {rutaBolivia.CalcularCosto()} Bs.");
Console.WriteLine($"Tiempo Total Estimado: {rutaBolivia.CalcularTiempo()} hrs.");

// ===============================
// ABSTRACT FACTORY
// ===============================

Console.WriteLine("\n=== ABSTRACT FACTORY ===");

// 1. Instanciamos la fábrica concreta (Chile)
// En este diseño, ConfiguracionPais es la Abstract Factory
ConfiguracionPais fabricaPais = new Chile(); 

// 2. Creamos la "Familia de Productos" relacionada con Chile
// Cada método devuelve un objeto específico para la logística de ese país
var etiqueta = fabricaPais.CrearEtiqueta();
var vehiculo = fabricaPais.CrearVehiculo();
var almacen  = fabricaPais.CrearAlmacen();


//Console.WriteLine($"Operando en: {configPaisActual.NombrePais}");

// ===============================
// STRATEGY
// ===============================
Console.WriteLine("\n=== STRATEGY ===");

// 1. Preparamos el calculador
CalcularCosto motorCalculo = new CalcularCosto();

// 2. Le asignamos la ruta (Composite) al envío (Factory Method)
envioEstandar.componenteRuta = rutaBolivia;
envioEstandar.peso = 25.5;

// 3. Aplicamos diferentes estrategias al mismo envío
Console.WriteLine("--- Calculando con Estrategia Estándar ---");
motorCalculo.SetEstrategia(new EstrategiaEstandar());
envioEstandar.SetCalculador(motorCalculo);
Console.WriteLine($"Costo Final: {envioEstandar.ProcesarCosto()} Bs.");

Console.WriteLine("--- Calculando con Estrategia Corporativa (Descuento) ---");
motorCalculo.SetEstrategia(new EstrategiaCorporativa());
envioEstandar.CantidadEnviosMensuales = 150; // Para activar el descuento
Console.WriteLine($"Costo Final: {envioEstandar.ProcesarCosto()} Bs.");


Console.WriteLine("\n=== FIN DEL PROGRAMA ===");