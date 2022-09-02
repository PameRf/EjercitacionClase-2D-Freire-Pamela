using System;

namespace Ejercicio04
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero = 1;
            bool bandera = true;
            int contadorPerfecto = 0;

            do
            {
                numero++;

                int suma = 0;

                for (int i = 1; i < numero; i++)
                {

                    if (numero % i == 0)
                    {
          
                        suma = suma + i;

                    }

                    if (suma == numero)
                    {
                        Console.WriteLine("{0}, es perfecto", numero);
                        contadorPerfecto++;
                        break;
                    }

                    if (contadorPerfecto == 4)
                    {
                        bandera = false;
                    }

                }

            } while (bandera == true);

            Console.ReadLine();
        }
    }
}

