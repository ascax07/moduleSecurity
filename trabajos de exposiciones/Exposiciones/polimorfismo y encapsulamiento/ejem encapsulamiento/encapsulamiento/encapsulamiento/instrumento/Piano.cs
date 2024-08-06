// Clase derivada
public class Piano : Instrumento
{
    public Piano(string nombre, int duracion, string marca)
        : base(nombre, duracion, "Piano", marca)
    {
    }

    // Método público para cambiar la duración usando el método protegido de la clase base
    public void CambiarDuracion(int nuevaDuracion)
    {
        EstablecerDuracion(nuevaDuracion);
    }
}

// Otra clase derivada
public class Guitarra : Instrumento
{
    public Guitarra(string nombre, int duracion, string marca)
        : base(nombre, duracion, "Guitarra", marca)
    {
    }
}