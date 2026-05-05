
class EstrategiaInternacional: ICosteoStrategy
{
    public double Calcular(Envio envio)
    {
        double tarifaKm = 0.8;
        double costoPeso = envio.peso * 3;
        double arancel = 50; // Costo fijo por aduanas

        return (envio.distancia * tarifaKm) + costoPeso;
    }
}
