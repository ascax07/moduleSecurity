using System;
using System.Collections.Generic;
using System.Linq;

// Clase que representa un libro
public class Libro
{
    public string Titulo { get; set; }
    public string Autor { get; set; }
    public string Genero { get; set; }
}

// Clase que representa un usuario
public class Usuario
{
    public string Nombre { get; set; }
    public List<string> GenerosFavoritos { get; set; }
}

// Estrategia de recomendación basada en género
public class EstrategiaRecomendacionGenero : IEsquemaRecomendacion
{
    public List<Libro> RecomendarLibros(Usuario usuario)
    {
        // Ejemplo de lógica para recomendar libros basados en el género
        return new List<Libro>
        {
            new Libro { Titulo = "Libro Ejemplo 1", Autor = "Autor Ejemplo 1", Genero = usuario.GenerosFavoritos.FirstOrDefault() }
        };
    }
}

// Estrategia de recomendación basada en autor
public class EstrategiaRecomendacionAutor : IEsquemaRecomendacion
{
    public List<Libro> RecomendarLibros(Usuario usuario)
    {
        // Ejemplo de lógica para recomendar libros basados en el autor
        return new List<Libro>
        {
            new Libro { Titulo = "Libro Ejemplo 2", Autor = "Autor Ejemplo 2", Genero = "Género Ejemplo 2" }
        };
    }
}

// Clase principal con el método Main
public class Program
{
    public static void Main(string[] args)
    {
        // Crear un usuario con géneros favoritos
        Usuario usuario = new Usuario
        {
            Nombre = "Juan",
            GenerosFavoritos = new List<string> { "Fantasía", "Ciencia Ficción" }
        };

        // Crear instancias de las estrategias de recomendación
        IEsquemaRecomendacion estrategiaGenero = new EstrategiaRecomendacionGenero();
        IEsquemaRecomendacion estrategiaAutor = new EstrategiaRecomendacionAutor();

        // Obtener recomendaciones basadas en el género
        List<Libro> librosPorGenero = estrategiaGenero.RecomendarLibros(usuario);
        Console.WriteLine("Recomendaciones basadas en género:");
        foreach (Libro libro in librosPorGenero)
        {
            Console.WriteLine($"Título: {libro.Titulo}, Autor: {libro.Autor}, Género: {libro.Genero}");
        }

        // Obtener recomendaciones basadas en el autor
        List<Libro> librosPorAutor = estrategiaAutor.RecomendarLibros(usuario);
        Console.WriteLine("Recomendaciones basadas en autor:");
        foreach (Libro libro in librosPorAutor)
        {
            Console.WriteLine($"Título: {libro.Titulo}, Autor: {libro.Autor}, Género: {libro.Genero}");
        }
    }
}