using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTarea3Ejercicio3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            float minutos;

            Console.WriteLine("Dime cuántos minutos has estado en el parking y te diré cuánto tienes que pagar: ");
            minutos = Convert.ToSingle(Console.ReadLine());

            if ((minutos > 0) && (minutos <= 60))
                {
                Console.WriteLine("Debes pagar 5€. ");

            }
            else if ((minutos > 60) && (minutos <= 120))
            {
                Console.WriteLine("Debes pagar 15€. ");
            }
            else if (minutos > 120)
            {
                Console.WriteLine("Debes pagar 40€. ");
            }
            else
            {
                Console.WriteLine("Obviamente, si has estado 0 minutos no tienes que pagar.");
            }
            
        }
    }
}
