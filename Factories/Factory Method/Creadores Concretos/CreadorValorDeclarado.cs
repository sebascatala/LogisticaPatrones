public class CreadorValorDeclarado():CreadorEnvio
{
    public override Envio CrearEnvio()
    {
        return new EnvioValorDeclarado();
    }
}