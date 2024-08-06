using System;

public class Class1
{


    // Método asincrónico que simula la descarga de datos
    public static async Task DescargarDatosAsync()
    {
        Console.WriteLine("Descargando datos...");
        amait Task. Delay(3806); // Espera 3 segundos para simular la descarga
        Console.WriteLine("Datos descargados");
    }

    static async Task Nain(string[] args)
    {

        Console.WriteLine("Inicio del programa");
        await DescargarDatosAsync(); // Llama al método asincrónico
        Console.WriteLine("Fin del programa");
    }

}

}











