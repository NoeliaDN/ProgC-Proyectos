using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleOperadorAnd
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool p, q;

            p = true;
            q = true;

            Console.WriteLine(p && q); // Nos dará TRUE. Si cambiamos alguno de los valores de tal manera que no nos salgan 2 true, dará false al ejecutarlo.

            byte edad;
            bool licencia;

            Console.WriteLine("¿Qué edad tienes? ");
            edad = Convert.ToByte(Console.ReadLine());

            Console.WriteLine("¿Tienes carné de conducir? (true/false) ");
            licencia = Convert.ToBoolean(Console.ReadLine());

            if (edad >= 18 && licencia == true)
            {
                Console.WriteLine("¡Enhorabuena! Puedes conducir. ");

            }
            else
            {
                Console.WriteLine("Lo siento, no puedes conducir.");
            }
        }// Si alguno de los valores es "false", el resultado dará FALSE, x lo que no podrá conducir a menos que ambos sean TRUE.
    }
}
