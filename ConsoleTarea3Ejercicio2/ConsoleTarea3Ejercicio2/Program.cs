using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTarea3Ejercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            long num, resultado;

            Console.WriteLine("Dime un número y te diré si es par o impar: ");
            num = Convert.ToInt64(Console.ReadLine());

            resultado = num % 2;
             // % implica que hacemos una división, en este caso num / 2, para que nos diga el resto. Al ser pares, no hay resto, el residuo es 0, porque el resultado es un número entero, sin decimales. Si tuviera resto, es decir, no fuera igual a 0, sería impar.

            if (resultado == 0)
            {
                Console.WriteLine($"El número {num} es par. ");

            }
            else
            {
                Console.WriteLine($"El número {num} es impar. ");
            }

            
        }
    }
}
