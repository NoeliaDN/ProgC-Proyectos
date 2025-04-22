using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleIfPractica2MultiplesSentencias
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double dividendo, divisor, resultado;

            //Pedimos el dividendo:

            Console.WriteLine("Dame el dividendo: ");
            dividendo = Convert.ToDouble(Console.ReadLine());

            //Pedimos el divisor:

            Console.WriteLine("Dame el divisor: ");
            divisor = Convert.ToDouble(Console.ReadLine());

            if (divisor != 0) 
            { 
                resultado = dividendo / divisor;
                Console.WriteLine($"{dividendo} / {divisor}: {resultado}.");
            }

            if (divisor == 0)
            {
                Console.WriteLine("No se puede dividir entre cero, mamón. ");
            }
        }
    }
}
