// 1. Instanciar los componentes de creación para el Director
IOrdenBuilder miBuilder = new OrdenAltoValor();
CreadorEnvio miFactory = new CreadorRefrigerado();
ConfiguracionPais miPais = new Bolivia();

// 2. Crear los eslabones de la cadena azul
Coordinador coordinador = new Coordinador();
Gerente gerente = new Gerente();
Director director = new Director(miBuilder, miFactory, miPais);

// 3. Construir la cadena usando el método público para enlazar los manejadores
coordinador.SetSiguiente(gerente);
gerente.SetSiguiente(director);

// 4. Iniciar el Cliente
Cliente miCliente = new Cliente(coordinador);

// Caso 1: Lo resuelve el Coordinador (Nivel <= 1)
miCliente.ProcesarIncidencia("Error menor en pesaje", 1);

Console.WriteLine();

// Caso 2: Escala hasta el Director (Nivel >= 3)
// El Director usará el Builder, Factory Method y Abstract Factory
miCliente.ProcesarIncidencia("Emergencia logística nacional", 3);