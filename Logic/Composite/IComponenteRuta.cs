public interface IComponenteRuta
{
    string Nombre { get; set; }
    double CalcularCosto();
    double CalcularTiempo();
}