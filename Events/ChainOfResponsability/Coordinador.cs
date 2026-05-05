public class Coordinador:ManejadorIncidencia
{
    public override void Manejar(Incidencia incidencia)
    {
        if(incidencia.Nivel <= 1)
        {
             Console.WriteLine("Coordinador resolvió: " + incidencia.Descripcion);
        }
        else
        {
            siguiente?.Manejar(incidencia);
        }
    }
}