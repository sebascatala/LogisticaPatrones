public class Coordinador:ManejadorIncidencia
{
    public override void Manejar(Incidencia incidencia)
    {
        if(Incidencia.Nivel <= 1)
        {
             Console.WriteLine("Coordinador resolvió: " + incidencia.Descripcion);
        }
        else
        {
            siguiente?.Manejar(incidencia);
        }
    }
}