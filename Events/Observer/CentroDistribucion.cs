public class CentroDistribucion
{

    private List<IOperador> Operadores = new List<IOperador>();
    public void agregarOperador(IOperador op)
    {
        Operadores.Add(op);
    }
    public void elimiarOperador(IOperador op)
    {
        Operadores.Remove(op);
    }
    public void notificarOperador(string mensaje)
    {
        foreach(var op in Operadores)
        {
            op.Actualizar(mensaje);
        }
    }
}