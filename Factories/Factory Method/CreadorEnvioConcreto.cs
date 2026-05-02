public class CreadorEnvioConcreto : CreadorEnvio
{
    public override Envio CrearEnvio(string tipoCarga)
    {
        switch (tipoCarga.ToLower()) {
            case "estandar":
                return new EnvioEstandar();
            case "refrigerado":
                return new EnvioRefrigerado();
            case "valordeclarado":
                return new EnvioValorDeclarado();
            default:
                throw new ArgumentException("Tipo de envío no reconocido");
        }
    }
}
