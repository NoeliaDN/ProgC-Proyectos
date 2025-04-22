using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleFor1Inicializacion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i;
            for(i = 1, Console.WriteLine($"Valor inicial de la variable {i}"); i <= 10; i++) // Solo tenemos 3 secciones separadas por punto y coma, pero en la primera y tercera sección podemos meter varios tipos de código entre comas.
            {
                Console.WriteLine(i);
            }
        }
    }
}
