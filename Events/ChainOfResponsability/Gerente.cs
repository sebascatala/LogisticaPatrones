public class Gerente:ManejadorIncidencia
{
    public override void Manejar(Incidencia incidencia)
    {
        if(Incidencia.Nivel <= 2)
        {
            Console.WriteLine("Gerente resolvió: " + incidencia.Descripcion);
        }
        else
        {
            siguiente?.Manejar(incidencia);
        }
    }
}