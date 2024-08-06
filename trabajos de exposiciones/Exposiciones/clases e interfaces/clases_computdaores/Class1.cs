using System;

// Clase Laptop extendiendo Computadora e implementando IEnergia
class Laptop : Computadora
{
    public bool TienePantallaTactil { get; set; }

    public void MostrarInformacionLaptop()
    {
        Console.WriteLine($"Computadora tipo: Laptop.");
        MostrarInformacion();
        Console.WriteLine($"Pantalla Táctil: {(TienePantallaTactil ? "Sí" : "No")}");
    }

    // Redefinir el método Encender para personalizar el mensaje
    public override void Encender()
    {
        Console.WriteLine("La laptop está encendida.");
    }
}
