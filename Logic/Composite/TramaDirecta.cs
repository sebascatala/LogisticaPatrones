internal class TramaDirecta : IComponenteRuta
{
    public string Nombre { get; set; }
    public double Costo { get; set; }
    public double Tiempo { get; set; }

    public TramaDirecta(string nombre, double costo, double tiempo)
    {
        Nombre = nombre;
        Costo = costo;
        Tiempo = tiempo;
    }
    public double CalcularCosto()
    {
        return Costo;
    }

    public double CalcularTiempo()
    {
        return Tiempo;
    }
}