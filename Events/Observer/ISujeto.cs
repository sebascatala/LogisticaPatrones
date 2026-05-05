public interface ISujeto
{
    void agregarOperador(IOperador op);
    void eliminarOperador(IOperador op);
    void notificarOperador(string mensaje);
}