public class Gerente:ManejadorIncidencia
{
    public Gerente(IOrdenBuilder builder, CreadorEnvio creador, ConfiguracionPais paisCfg) : base(builder, creador, paisCfg)
    {
    }

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