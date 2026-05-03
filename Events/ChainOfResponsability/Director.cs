public class Director:ManejadorIncidencia
{
    public void generarOrden(string tipoCarga)
    {
        switch(tipoCarga.ToLower())
        {
            case"estandar":
            creador = new CreadorEstandar();
            break;
            case"refrigerado":
            creador = new CreadorRefrigerado();
            break;
            case"valor declarado":
            creador = new CreadorValorDeclarado();
            break;
            default:
            throw new Exception("Tipo de envio no soportado");
        }
    }
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