using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleInstruccionesAnidadas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Variables

            int i; //Variable que se encarga del bucle exterior
            int j; // Variable de control que se encarga del bucle interior/anidado.
            int resultado; // GUardar el valor de la multiplicación

            for (i = 1; i <= 10; i++) 
            {
                Console.WriteLine("\n");
                Console.WriteLine($"Tabla de multiplicar del {i}:\n"); // Nos muestra la tabla actual

                for (j = 1; j <= 10; j++)
                {
                    resultado = i * j;

                    Console.WriteLine($"El resultado de {1} * {j} es: {resultado}");
                }
            }

            Console.ReadKey();



        }
    }
}
