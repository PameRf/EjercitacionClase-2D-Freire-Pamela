using System;

namespace Ejercicio07
{
    class Program
    {
        static void Main(string[] args)
        {
            float valorHora;
            string nombre;
            int antiguedad;
            int horasTrabajadas;

            float sueldoBruto;
            float sueldoNeto;

            float porcentaje;

            Console.WriteLine("Ingrese el valor por hora trabajada");
            valorHora = float.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el nombre del empleado");
            nombre = Console.ReadLine();
            Console.WriteLine("Ingrese anios de antiguedad");
            antiguedad= int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese cantidad de horas trabajadas");
            horasTrabajadas = int.Parse(Console.ReadLine());

            sueldoBruto = (valorHora * horasTrabajadas) + (antiguedad * 150);

            porcentaje = (sueldoBruto * 13) / 100;

            sueldoNeto = sueldoBruto - porcentaje;

            Console.WriteLine("----Recibo de sueldo----");
            Console.WriteLine("Nombre {0}", nombre);
            Console.WriteLine("Antiguedad {0}", antiguedad);
            Console.WriteLine("Valor hora {0}", valorHora);
            Console.WriteLine("Sueldo bruto {0}", sueldoBruto);
            Console.WriteLine("Sueldo neto {0}", sueldoNeto);




        }
    }
}

