public class EnvioValorDeclarado : Envio {
    public double montoAsegurado;
    public void validacionMontoAsegurado(double monto) {
        if (monto > montoAsegurado) {
            throw new Exception("El monto asegurado no es suficiente para este envío.");
        }
        else {
            Console.WriteLine("El monto asegurado es suficiente para este envío.");
        }
    }
}