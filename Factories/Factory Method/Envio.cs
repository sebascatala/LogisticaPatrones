public abstract class Envio
{
    public double peso { get; set; } = 0.0;
    public string dimensiones { get; set; } = string.Empty;
    public double distancia { get; set; } = 0.0;
    public double CantidadEnviosMensuales { get; set; } = 0.0; // Para uso en EstrategiaCorporativa
    public IComponenteRuta? componenteRuta; // Componente para el patrón Composite

    // Conexión con el sistema de cálculo de costos (Patrón Strategy)
    protected CalcularCosto? calculador;

    public void SetCalculador(CalcularCosto calculador) {
        this.calculador = calculador;
    }

    public virtual double ProcesarCosto() {
        if (calculador == null) throw new Exception("No se ha definido una estrategia de costo.");
        return calculador.EjecutarCalculo(this);
    }
}