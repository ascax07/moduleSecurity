using System;
using System.Threading.Tasks;

namespace PersonaApp
{
    // Interfaz ICalculable
    public interface ICalculable
    {
        double CalcularSalario();
    }

    // Clase base Persona
    public class Persona
    {
        // Propiedades de la clase
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public string Direccion { get; set; }

        // Constructor que inicializa los atributos
        public Persona(string nombre, int edad, string direccion)
        {
            Nombre = nombre;
            Edad = edad;
            Direccion = direccion;
        }

        // Constructor sin parámetros y valores no iniciados
        public Persona()
        {
            Nombre = "";
            Edad = 0;
            Direccion = " ";
        }

        // Método para mostrar información de la persona
        public virtual void MostrarInformacion()
        {
            Console.WriteLine($"Nombre: {Nombre}");
            Console.WriteLine($"Edad: {Edad}");
            Console.WriteLine($"Dirección: {Direccion}");
        }

        // Método asincrónico que simula la lectura de datos
        public async Task LeerDatosAsync()
        {
            Console.WriteLine("Iniciando lectura de datos...");
            await Task.Delay(2000); // Simula una operación asincrónica con un retraso de 2 segundos
            Console.WriteLine("Datos leídos correctamente.");
        }
    }

    // Clase derivada Empleado que hereda de Persona
    public class Empleado : Persona, ICalculable
    {
        // Propiedad adicional para la clase Empleado
        public double Salario { get; set; }

        // Constructor que inicializa todos los atributos
        public Empleado(string nombre, int edad, string direccion, double salario)
            : base(nombre, edad, direccion)
        {
            Salario = salario;
        }

        // Constructor sin parámetros con valores predeterminados
        public Empleado()
            : base()
        {
            Salario = 0.0;
        }

        // Método sobrescrito para mostrar la información del empleado
        public override void MostrarInformacion()
        {
            base.MostrarInformacion();
            Console.WriteLine($"Salario: {Salario}");
        }

        // Implementación del método de la interfaz ICalculable
        public double CalcularSalario()
        {
            return Salario;
        }
    }

    // Clase principal Program
    public class Program
    {
        public static async Task Main()
        {
            // Crear una instancia de la clase Persona
            Persona persona = new Persona("Jose Gasca", 18, "Calle 64");
            persona.MostrarInformacion();
            await persona.LeerDatosAsync(); // Llamada al método asincrónico

            Console.WriteLine(); // Línea en blanco para separar las salidas

            // Crear una instancia de la clase Empleado
            Empleado empleado = new Empleado("William Gonzales", 17, "Campoalegre", 80000);
            empleado.MostrarInformacion();
            await empleado.LeerDatosAsync(); // Llamada al método asincrónico
        }
    }
}
