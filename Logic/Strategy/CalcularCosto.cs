public class CalcularCosto {
    private ICosteoStrategy _estrategia;

    public void SetEstrategia(ICosteoStrategy estrategia) {
        this._estrategia = estrategia;
    }

    public double EjecutarCalculo(Envio datoEnvio) {
        return _estrategia.Calcular(datoEnvio);
    }
}