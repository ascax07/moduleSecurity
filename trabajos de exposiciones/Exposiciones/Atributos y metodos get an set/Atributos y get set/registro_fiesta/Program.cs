using System;

class Program
{
    static void Main()
    {
        var fiesta = new RegistroFiesta
        {
            Nombre = "Cumpleaños de Ana",
            Fecha = new DateTime(2024, 8, 10),
            Descripcion = "Fiesta en la playa",
            NumeroInvitados = 50,
            Lugar = "Playa Santa María"
        };

        // Ejemplo de uso de la propiedad obsoleta
        fiesta.DescripcionAntigua = "Fiesta en la playa";

        // Mostrar la información de la fiesta
        Console.WriteLine($"Nombre: {fiesta.Nombre}");
        Console.WriteLine($"Fecha: {fiesta.Fecha.ToShortDateString()}");
        Console.WriteLine($"Descripción: {fiesta.Descripcion}");
        Console.WriteLine($"Número de Invitados: {fiesta.NumeroInvitados}");
        Console.WriteLine($"Lugar: {fiesta.Lugar}");
    }
}
