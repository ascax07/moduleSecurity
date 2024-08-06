using System.Diagnostics.Metrics;

class Program
{
    static void Main()
    {
        Instrumento miInstrumento = new Instrumento();
        Instrumento miPiano = new Piano();
        Instrumento miGuitarra = new Guitarra();

        // Llamadas al método Tocar() en diferentes instancias
        miInstrumento.Tocar();  // Salida: El instrumento suena.
        miPiano.Tocar();       // Salida: El piano toca una melodía clásica.
        miGuitarra.Tocar();    // Salida: La guitarra toca un riff de rock.
    }
}