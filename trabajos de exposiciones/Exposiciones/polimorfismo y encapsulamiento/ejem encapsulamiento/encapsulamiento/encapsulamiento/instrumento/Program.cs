using System.Diagnostics.Metrics;

class Program
{
    static void Main()
    {
        // Crear instancias de Instrumento y sus derivados
        Instrumento instrumento = new Instrumento("Instrumento Genérico", 5, "Instrumento", "YAMAHA");
        Piano piano = new Piano("Piano de electrico", 10, "YAMAHA");
        Guitarra guitarra = new Guitarra("Guitarra Eléctrica", 8, "D'addario");

        // Acceso a miembros públicos
        instrumento.Nombre = "Instrumento";
        instrumento.MostrarInformacion();

        // Acceso a miembros protegidos y privados en las clases derivadas
        piano.CambiarDuracion(15);
        piano.MostrarInformacion();

        //La marca es interna, por lo que no es accesible fuera del ensamblaje actual.
        // Por ejemplo:
        // Console.WriteLine(piano.marca); // Esto generaría un error si se descomenta

        // La duración y el tipo no son accesibles directamente en la clase derivada, pero
        // se accede a través de métodos públicos o protegidos de la clase base.
        guitarra.MostrarInformacion();
    }
}