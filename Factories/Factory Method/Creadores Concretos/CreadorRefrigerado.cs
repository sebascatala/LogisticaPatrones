public class CreadorRefrigerado():CreadorEnvio
{
    public override Envio CrearEnvio()
    {
        return new EnvioRefrigerado();
    }
}