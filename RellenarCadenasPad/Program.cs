using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RellenarCadenasPad
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string cadena1 = "Hola a todos";

            Console.WriteLine(cadena1);

            //Después de PadLeftt:

            Console.WriteLine(cadena1.PadLeft(15));//Ponemos 15, xq Hola a todos tiene 12 caracteres, y le sumamos 3 espacios en blanco

            //Ahora probaremos con PadRight y la SOBRECARGA que utiliza un char como segundo argumento:

            Console.WriteLine(cadena1.PadRight(15, '#'));

        }
    }
}
