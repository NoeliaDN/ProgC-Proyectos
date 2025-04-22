using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleForCondicion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i;

            Console.WriteLine("PRÁCTICA SECCIÓN CONDICIÓN:\n");

            for (i = 1; i < 11; i++)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("-------------------------------------------------------\n");

            Console.WriteLine("ASIGNACIÓN COMPUESTA:\n");

            int x = 2;

            Console.WriteLine(x);

            x = x + 5;

            Console.WriteLine(x);

            //ASIGNACIÓN COMPUESTA DE SUMA (con el formato xop=y):

            x += 5; //Vemos que hace lo mismo, suma 5, pero con un formato más simplificado.

            Console.WriteLine(x);

            //Lo mismo con las asignaciones compuestas de resta, división y multiplicación: +=, -=, *= y /=.
        }
    }
}
