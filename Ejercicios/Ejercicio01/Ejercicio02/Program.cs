using System;

namespace Ejercicio02
{
    class Program
    {
        static void Main(string[] args)
        {
            string numeroIngresado;
            int numero;
            bool resultado;
            double numeroCubo;
            double numeroCuadrado;

            Console.WriteLine("Ingrese un numero");
            numeroIngresado = Console.ReadLine();
            resultado = int.TryParse(numeroIngresado, out numero);

            while (resultado == false || numero <= 0)
            {
                Console.WriteLine("\"ERROR. ¡Reingresar número!\"");
                numeroIngresado = Console.ReadLine();
                resultado = int.TryParse(numeroIngresado, out numero);

            }
            if (resultado == true)
            {

                numeroCubo = Math.Pow(numero, 3);
                numeroCuadrado = Math.Pow(numero, 2);

                Console.WriteLine($"El numero ingresado es {numero}, el numero al cubo es {numeroCubo} y el numero al cuadrado {numeroCuadrado}");
            }
        }
    }
}

