public class Gerente:ManejadorIncidencia
{
    public override void Manejar(Incidencia incidencia)
    {
        if(incidencia.Nivel <= 2)
        {
            Console.WriteLine("Gerente resolvió: " + incidencia.Descripcion);
        }
        else
        {
            siguiente?.Manejar(incidencia);
        }
    }
}