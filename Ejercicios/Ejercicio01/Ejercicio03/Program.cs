using System;

namespace Ejercicio03
{
    class Program
    {
        static void Main(string[] args)
        {
            string numeroIngresado;
            int numero;
            bool resultado;
            string respuesta;


            do
            {
                Console.WriteLine("Ingrese un numero");
                numeroIngresado = Console.ReadLine();
                resultado = int.TryParse(numeroIngresado, out numero);
                if (resultado == true && numero > 0)
                {
                    for (int i = 1; i < numero; i++)
                    {
                        if (i % 2 != 0)
                        {
                            Console.WriteLine($"Es primo {i}");
                        }

                    }
                }

                Console.WriteLine("Desea salir: si/no");
                respuesta = Console.ReadLine();

            } while (respuesta == "no" || resultado == false);

        }
    }
}

