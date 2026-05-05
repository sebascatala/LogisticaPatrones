public class Cliente
{
    private readonly ManejadorIncidencia _primerManejador;

    public Cliente(ManejadorIncidencia manejador)
    {
        _primerManejador = manejador;
    }

    public void ProcesarIncidencia(string desc, int nivel)
    {
        Incidencia nuevaIncidencia = new Incidencia(nivel, desc);

        Console.WriteLine($"[Cliente] Enviando reporte: {desc} (Nivel {nivel})");
        
        // Inicia el flujo en la cadena azul
        _primerManejador.Manejar(nuevaIncidencia);
    }
}