public class Peru(): ConfiguracionPais
{
    public override IAlmacen CrearAlmacen()
    {
        return new AlmacenPeru();
    }

    public override IEtiqueta CrearEtiqueta()
    {
        return new EtiquetaPeru();
    }

    public override IVehiculo CrearVehiculo()
    {
        return new VehiculoPeru();
    }
}