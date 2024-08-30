using System;
using System.Threading.Tasks;

namespace PersonaApp
{

    public interface ICalculable
    {
        double CalcularSalarioDiario();
    }


    public class Persona
    {

        public string Nombre { get; set; }
        public int Edad { get; set; }
        public string Direccion { get; set; }


        public Persona(string nombre, int edad, string direccion)
        {
            Nombre = nombre;
            Edad = edad;
            Direccion = direccion;
        }

        public Persona()
        {
            Nombre = "";
            Edad = 0;
            Direccion = " ";
        }

        public virtual void MostrarInformacion()
        {
            Console.WriteLine($"Nombre: {Nombre}");
            Console.WriteLine($"Edad: {Edad}");
            Console.WriteLine($"Dirección: {Direccion}");
        }


        public void SolicitarDatosPersona()
        {
            Console.Write("Ingrese el nombre: ");
            Nombre = Console.ReadLine();

            Console.Write("Ingrese la edad: ");
            Edad = int.Parse(Console.ReadLine());

            Console.Write("Ingrese la dirección: ");
            Direccion = Console.ReadLine();
        }
    }


    public class Empleado : Persona, ICalculable
    {

        public double Salario { get; set; }
        public int DiasTrabajados { get; set; }


        public Empleado(string nombre, int edad, string direccion, double salario, int diasTrabajados)
            : base(nombre, edad, direccion)
        {
            Salario = salario;
            DiasTrabajados = diasTrabajados;
        }

        public Empleado()
            : base()
        {
            Salario = 0.0;
            DiasTrabajados = 0;
        }


        public override void MostrarInformacion()
        {
            base.MostrarInformacion();
            Console.WriteLine($"Salario: {Salario}");
            Console.WriteLine($"Días trabajados: {DiasTrabajados}");
            Console.WriteLine($"Salario diario: {CalcularSalarioDiario()}");
        }


        public double CalcularSalarioDiario()
        {
            if (DiasTrabajados > 0)
            {
                return Salario / DiasTrabajados;
            }
            else
            {
                Console.WriteLine("Los días trabajados deben ser mayores a 0.");
                return 0;
            }
        }


        public void SolicitarDatosEmpleado()
        {
            SolicitarDatosPersona(); // Solicitar nombre, edad y dirección

            Console.Write("Ingrese el salario: ");
            Salario = double.Parse(Console.ReadLine());

            Console.Write("Ingrese los días trabajados: ");
            DiasTrabajados = int.Parse(Console.ReadLine());
        }


        public async Task ObtenerDatosEmpleadoAsync()
        {
            Console.WriteLine("Obteniendo datos del empleado...");
            await Task.Delay(3000);
            Console.WriteLine("Datos obtenidos correctamente.");
        }
    }


    public class Program
    {
        public static async Task Main()
        {

            Persona persona = new Persona();
            Console.WriteLine("Ingrese los datos de la persona:");
            persona.SolicitarDatosPersona();

            Console.WriteLine();


            Empleado empleado = new Empleado();
            Console.WriteLine("Ingrese los datos del empleado:");
            empleado.SolicitarDatosEmpleado();


            await empleado.ObtenerDatosEmpleadoAsync();


            Console.WriteLine("\nInformación de la persona:");
            persona.MostrarInformacion();

            Console.WriteLine("\nInformación del empleado:");
            empleado.MostrarInformacion();
        }
    }
}