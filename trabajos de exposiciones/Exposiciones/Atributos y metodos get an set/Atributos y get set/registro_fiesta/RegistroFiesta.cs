using System;
using System.ComponentModel;
using System.Runtime.InteropServices; // Para ComVisible

[Serializable] // Marca la clase como serializable
[ComVisible(true)] // Hace la clase visible para COM (Interoperabilidad)
public class RegistroFiesta
{
    [NonSerialized] // Indica que este campo no debe ser serializado
    private string _comentarios;

    [DefaultValue("Desconocido")] // Establece un valor por defecto para la propiedad
    public string Nombre { get; set; }

    public DateTime Fecha { get; set; }

    [Obsolete("Esta propiedad está obsoleta. Usa 'Descripcion' en su lugar.")]
    public string DescripcionAntigua { get; set; }

    public string Descripcion { get; set; }

    [Category("Detalles de Fiesta")] // Categoriza la propiedad en el diseñador
    public int NumeroInvitados { get; set; }

    public string Lugar { get; set; }
}
