public class Director:ManejadorIncidencia
{
    public override void Manejar(Incidencia incidencia)
    {
        if(Incidencia.Nivel <=3)
        {
            Console.WriteLine("Director resolvió: " + incidencia.Descripcion);
        }
        else
        {
            Console.WriteLine("Incidencia Critica: requiere otro nivel " );
        }
    }
}