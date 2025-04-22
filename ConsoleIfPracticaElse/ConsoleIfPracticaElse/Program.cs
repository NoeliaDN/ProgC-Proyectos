using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleIfPracticaElse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Explicación:

            //if (condicion)
            //{
            //    // Código a ejecutar si la consola es true.
            //}
            //else // No lleva condición, por lo que usa la misma de "if".
            //{
            //    // El código a ejecutar si la condición resulta ser false.
            //}
            //Ejercicio:

            byte edad; // Usaremos "byte" xq la edad tiene que ser un número entero sin signos.

            Console.WriteLine("¿Qué edad tienes?");
            edad = Convert.ToByte(Console.ReadLine());

            if (edad >= 18) 
            {
                Console.WriteLine("Eres mayor de edad. "); // Se ejecuta si la condición es true.

            }
            else
            {
                Console.WriteLine("Eres menor de edad"); // Se ejecuta si la condición es false.
            }

            





        }
    }
}
