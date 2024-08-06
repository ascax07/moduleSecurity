using System;


// Interfaz para la estrategia de recomendación
public interface IEsquemaRecomendacion
{
    List<Libro> RecomendarLibros(Usuario usuario);
}