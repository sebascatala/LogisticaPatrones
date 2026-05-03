public class EnvioRefrigerado : Envio
{
    public double temperaturaConservacion;
    public void validacionTemperatura(double temperatura) {
        if (temperatura > temperaturaConservacion) {
            throw new Exception("La temperatura no es adecuada para este envío.");
        }
        else {
            Console.WriteLine("La temperatura es adecuada para este envío.");
        }
    }
}