using System;

class Programa
{
    static void Main()
    {
        // Crear una instancia de Laptop
        Laptop miLaptop = new Laptop();
        miLaptop.Marca = "HP";
        miLaptop.Procesador = "Intel i5";
        miLaptop.TienePantallaTactil = true;

        // Mostrar la información de la laptop
        miLaptop.MostrarInformacionLaptop();

        // Usar los métodos de la interfaz IEnergia en Laptop
        ((IEnergia)miLaptop).Encender();

     
    }
}
