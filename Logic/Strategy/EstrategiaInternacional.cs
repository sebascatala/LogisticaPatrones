
class EstrategiaInternacional: ICosteoStrategy
{
    public double Calcular(Envio envio)
    {
        double tarifaKm = 0.8;
        double costoPeso = envio.peso * 3;

        // Obtenemos el costo base de la ruta (sea simple o compuesta)
        double costoBase = envio.componenteRuta?.CalcularCosto() ?? 0.0;
        
        // Aplicamos lógica de peso (por ejemplo, $2 por kilo)
        Console.WriteLine($"Estrategia Internacional: Costo sin ruta {costoBase} Bs., Costo con la ruta: {costoBase - envio.componenteRuta?.CalcularCosto() ?? 0.0}%");
        return costoBase + (envio.distancia * tarifaKm) + costoPeso;
        
    }
}
