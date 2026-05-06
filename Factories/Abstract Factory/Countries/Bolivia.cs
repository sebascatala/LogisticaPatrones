public class Bolivia(): ConfiguracionPais
{
    public override IAlmacen CrearAlmacen()
    {
        return new AlmacenBolivia();
    }

    public override IEtiqueta CrearEtiqueta()
    {
        return new EtiquetaBolivia();
    }

    public override IVehiculo CrearVehiculo()
    {
        return new VehiculoBolivia();
    }
}