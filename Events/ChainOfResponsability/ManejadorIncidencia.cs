public abstract class ManejadorIncidencia:IOperador
{
    protected ManejadorIncidencia siguiente;

    public void SetSiguiente(ManejadorIncidencia s)
    {
        siguiente = s;   
    }
    public abstract void Manejar(Incidencia incidencia);

    public void Actualizar(string mensaje)
    {
        Console.WriteLine($"[{this.GetType().Name}] Notificación recibida: {mensaje}");
    }
}