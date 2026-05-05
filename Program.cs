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

IOperador operador1 = new OperadorCampo("Juan");
IOperador supervisor1 = new Supervisor("María");

centro.agregarOperador(operador1);
centro.agregarOperador(supervisor1);

centro.notificarOperador("Nuevo envío registrado en el centro de distribución.");


// ===============================
// CHAIN OF RESPONSIBILITY
// ===============================
Console.WriteLine("\n=== CHAIN OF RESPONSIBILITY ===");

ManejadorIncidencia coordinador = new Coordinador();
ManejadorIncidencia gerente = new Gerente();
ManejadorIncidencia director = new Director();

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


Console.WriteLine("\n=== FIN DEL PROGRAMA ===");
