internal class EstrategiaCorporativa : ICosteoStrategy
{
    public double Calcular(Envio envio)
    {
        double costoBase = (envio.distancia * 0.4) + (envio.peso * 1.5)+ envio.componenteRuta?.CalcularCosto() ?? 0.0;

        double descuento = 0.2; // Descuento base para clientes corporativos

        if (envio.CantidadEnviosMensuales > 100)
            descuento = 0.20;
        else if (envio.CantidadEnviosMensuales > 50)
            descuento = 0.10;
        Console.WriteLine($"Estrategia Corporativa: Costo sin ruta {costoBase} Bs., Costo con la ruta: {costoBase - envio.componenteRuta?.CalcularCosto() ?? 0.0}%");
        return costoBase * (1 - descuento);
    }
}
