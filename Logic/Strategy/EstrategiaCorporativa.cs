internal class EstrategiaCorporativa : ICosteoStrategy
{
    public double Calcular(Envio envio)
    {
        double costoBase = (envio.distancia * 0.4) + (envio.peso * 1.5);

        double descuento = 0;

        if (envio.CantidadEnviosMensuales > 100)
            descuento = 0.20;
        else if (envio.CantidadEnviosMensuales > 50)
            descuento = 0.10;

        return costoBase * (1 - descuento);
    }
}
