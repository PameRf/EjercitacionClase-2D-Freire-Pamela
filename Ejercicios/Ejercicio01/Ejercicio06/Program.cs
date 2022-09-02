using System;

namespace Ejercicio06
{
    class Program
    {
        static void Main(string[] args)
        { 
            string primerAnio;
            string segundoAnio;

            int anioUno;
            int anioDos;

            Console.WriteLine("Ingrese anio de inicio");
            primerAnio = Console.ReadLine();
            int.TryParse(primerAnio, out anioUno);
            Console.WriteLine("Ingrese el anio de fin");
            segundoAnio = Console.ReadLine();
            int.TryParse(segundoAnio, out anioDos);


            for (int i = anioUno; i < anioDos; i++)
            {
             
                if((i % 4 ==0 )||(i % 100 ==0) && (i % 400 == 0))
                {
                    Console.WriteLine("Es anio bisiesto {0}", i);
                }

            }

        }
    }
}

