public class CalcularCosto {
    private ICosteoStrategy? _estrategia;

    public void SetEstrategia(ICosteoStrategy estrategia) {
        _estrategia = estrategia;
    }

    public double EjecutarCalculo(Envio datoEnvio) {
        return _estrategia?.Calcular(datoEnvio) ?? 0.0;
    }
}