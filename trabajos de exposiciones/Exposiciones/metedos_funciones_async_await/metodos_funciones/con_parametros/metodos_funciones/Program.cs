using System;

    class Program
    {
        //Declaramos la funcion Suma la cual recibe como parametros 2 numeros enteros
        //Esta función nos devolvera un entero
        static int Suma(int num1, int num2)
        {
            //Sumamos los dos parametros y devolvemos el resultado return num1 + num2;
            return num1 + num2
        }
        public static void Main(string[] args)
        {
            //Declaramos una varaible llamada resultado int resultado;
            int resultado
            //Llamamos a la funcion suma pasandole dos numeros enteros resultado Suma(5, 5);
            resultado = Suma(5, 5);

            Console.WriteLine("El resultado de su suma es: " + resultado);

        }
    }







