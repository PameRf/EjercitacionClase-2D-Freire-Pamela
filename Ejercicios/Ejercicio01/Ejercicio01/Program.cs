using System;

namespace Ejercicio01
{
    class Program
    {
        static void Main(string[] args)
        {
            string numeroIngresado;
            int numero;
            int numeroMinimo = 0;
            int numeroMaximo = 0;
            int flagNumero = 0;
            bool resultado;
            int acumulador = 0;
            float promedio;


            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Ingrese un numero: ");
                numeroIngresado = Console.ReadLine();
                resultado = int.TryParse(numeroIngresado, out numero);

                if (resultado == true)
                {

                    if (flagNumero == 0 || numero <= numeroMinimo)
                    {
                        numeroMinimo = numero;
                        flagNumero = 1;

                    }
                    if (numero >= numeroMaximo)
                    {
                        numeroMaximo = numero;
                    }
                }
                acumulador += numero;
            }

            promedio = acumulador / 5;
            Console.WriteLine($"El numero mayor es {numeroMaximo} el numero menor es {numeroMinimo} y el promedio es {promedio}");

        }
    }
}

