public abstract class ManejadorIncidencia:IOperador
{
    protected ManejadorIncidencia? siguiente;

    protected ManejadorIncidencia(IOrdenBuilder builder, CreadorEnvio creador, ConfiguracionPais paisCfg) : base(builder, creador, paisCfg)
    {
    }

    public void SetSiguiente(ManejadorIncidencia s)
    {
        siguiente = s;   
    }
    public abstract void Manejar(Incidencia incidencia);

    public override void Actualizar(string mensaje)
    {
        Console.WriteLine($"[{GetType().Name}] Notificación recibida: {mensaje}");
    }
}