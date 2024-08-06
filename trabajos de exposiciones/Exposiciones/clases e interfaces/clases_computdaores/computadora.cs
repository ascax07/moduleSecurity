using System;

// Clase Computadora implementando la interfaz IEnergia
class Computadora : IEnergia
{
    public string Marca { get; set; }
    public string Procesador { get; set; }

    // Implementación del método Encender
    public virtual void Encender()
    {
        Console.WriteLine("La computadora está encendida.");
    }

    // Implementación del método Apagar
    public void Apagar()
    {
        Console.WriteLine("La computadora está apagada.");
    }

    public void MostrarInformacion()
    {
        Console.WriteLine($"Marca: {Marca}");
        Console.WriteLine($"Procesador: {Procesador}");
    }
}

