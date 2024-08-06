using System;

// Clase base
public class Instrumento
{
    // Modificador de acceso público: accesible desde cualquier parte
    public string Nombre { get; set; }

    // Modificador de acceso privado: accesible solo dentro de la clase
    private int duracion;

    // Modificador de acceso protegido: accesible en la clase base y en clases derivadas
    protected string tipo;

    // Modificador de acceso interno: accesible solo dentro del mismo ensamblaje (proyecto)
    internal string marca;

    // Constructor para inicializar el instrumento
    public Instrumento(string nombre, int duracion, string tipo, string marca)
    {
        this.Nombre = nombre;
        this.duracion = duracion;
        this.tipo = tipo;
        this.marca = marca;
    }

    // Método público para mostrar información
    public void MostrarInformacion()
    {
        Console.WriteLine($"Nombre: {Nombre}");
        Console.WriteLine($"Duración: {duracion} segundos");
        Console.WriteLine($"Tipo: {tipo}");
        Console.WriteLine($"Marca: {marca}");
    }

    // Método protegido para establecer la duración
    protected void EstablecerDuracion(int duracion)
    {
        this.duracion = duracion;
    }
}
