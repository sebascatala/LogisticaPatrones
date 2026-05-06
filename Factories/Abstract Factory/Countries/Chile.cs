public class Chile(): ConfiguracionPais
{
    public override IAlmacen CrearAlmacen()
    {
        return new AlmacenChile();
    }

    public override IEtiqueta CrearEtiqueta()
    {
        return new EtiquetaChile();
    }

    public override IVehiculo CrearVehiculo()
    {
        return new VehiculoChile();
    }
}