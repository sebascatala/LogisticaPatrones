public class Director : ManejadorIncidencia
{
    private IOrdenBuilder _builder;

    public void SetBuilder(IOrdenBuilder builder)
    {
        _builder = builder;
    }

    public OrdenDespacho generarOrden(string tipoCarga, double peso, string dimensiones)
    {
        CreadorEnvio creador = SeleccionarCreador(tipoCarga);
        Envio nuevoEnvio = creador.CrearEnvio();

        nuevoEnvio.peso = peso;
        nuevoEnvio.dimensiones = dimensiones;

        _builder.generarId();
        _builder.añadirDescripcion();
        _builder.añadirDocumentacionAduanera();
        _builder.añadirSeguroTransito();

        OrdenDespacho ordenFinal = _builder.obtenerOrden();

        if (nuevoEnvio is EnvioRefrigerado refrigerado)
        {
            ordenFinal.asignarInstruccion($"MANTENER FRÍO: {refrigerado.temperaturaConservacion}°C");
        }

        return ordenFinal;
    }

    private CreadorEnvio SeleccionarCreador(string tipo)
    {
        switch (tipo.ToLower())
        {
            case "estandar": return new CreadorEstandar();
            case "refrigerado": return new CreadorRefrigerado();
            case "valor declarado": return new CreadorValorDeclarado();
            default: throw new Exception("Tipo no válido");
        }
    }

    public override void Manejar(Incidencia incidencia)
    {
        if (incidencia.Nivel <= 3)
        {
            Console.WriteLine("Director resolvió: " + incidencia.Descripcion);
        }
        else
        {
            Console.WriteLine("Incidencia crítica: requiere otro nivel");
        }
    }
}