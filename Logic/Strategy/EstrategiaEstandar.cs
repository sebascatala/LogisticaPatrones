class EstrategiaEstandar : ICosteoStrategy
{
    public double Calcular(Envio envio)
    {
        double tarifaKm = 0.5;
        double costoPeso = envio.peso * 2;

        return (envio.distancia * tarifaKm) + costoPeso;
    }
}
