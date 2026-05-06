public class Coordinador:ManejadorIncidencia
{
    public Coordinador(IOrdenBuilder builder, CreadorEnvio creador, ConfiguracionPais paisCfg) : base(builder, creador, paisCfg)
    {
    }

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