public abstract class ManejadorIncidencia
{
    protected ManejadorIncidencia siguiente;

    public void SetSiguiente(ManejadorIncidencia s)
    {
        siguiente = s;   
    }
    public abstract void Manejar(Incidencia incidencia);
}