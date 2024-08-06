using System.Diagnostics.Metrics;

class Program
{
    static void Main()
    {
        Instrumento instrumento = new Instrumento();

        // Llamada al método Tocar sin parámetros
        instrumento.Tocar();

        // Llamada al método Tocar con un ritmo
        instrumento.Tocar("lento");

        // Llamada al método Tocar con ritmo y duración
        instrumento.Tocar("Rápido", 10);
    }
}