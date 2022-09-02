using System;

namespace Ejercicio05
{
    class Program
    {
        static void Main(string[] args)
        {
            string numeroIngresado;
            int numero;
            bool resultado;
            int sumaAnterior = 0;
            int sumaPosterior = 0;

            Console.WriteLine("Ingrese un numero");
            numeroIngresado = Console.ReadLine();
            resultado = int.TryParse(numeroIngresado, out numero);

            if(resultado== true)
            {

                for (int centro = 1; centro < numero; centro++)
                {
                    for (int i = 0; i < centro; i++)
                    {
                        sumaAnterior += i;
                    }
                    for (int j = centro +1; j <= sumaAnterior; j++)
                    {
                        if ((sumaAnterior == sumaPosterior) || (sumaPosterior > sumaAnterior))
                        {
                            break;
                        } 
                     
                        sumaPosterior += j;
                    }
                    if(sumaAnterior == sumaPosterior)
                    {
                        Console.WriteLine("El numero del centro es {0}", centro);
                    }
                }

            }
        }
    }
}

