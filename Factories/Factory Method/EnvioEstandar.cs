public class EnvioEstandar : Envio
{
    public void validacionDimensiones(string dimensiones) {
        if (dimensiones.Length > 20) {
            throw new Exception("Las dimensiones del envío estándar no pueden exceder los 20 caracteres.");
        }
        Console.WriteLine("Las dimensiones del envío estándar son válidas.");
    }
}