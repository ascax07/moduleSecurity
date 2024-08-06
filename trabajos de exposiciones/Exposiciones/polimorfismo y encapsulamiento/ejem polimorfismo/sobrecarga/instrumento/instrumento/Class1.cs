using System;

public class Instrumento
{
    // Método sobrecargado para tocar sin parámetros
    public void Tocar()
    {
        Console.WriteLine("El instrumento suena.");
    }

    // Método sobrecargado para tocar con un ritmo específico
    public void Tocar(string ritmo)
    {
        Console.WriteLine($"El instrumento suena con ritmo: {ritmo}");
    }

    // Método sobrecargado para tocar con un ritmo específico y duración
    public void Tocar(string ritmo, int duracion)
    {
        Console.WriteLine($"El instrumento suena con ritmo: {ritmo} durante {duracion} segundos.");
    }
}
