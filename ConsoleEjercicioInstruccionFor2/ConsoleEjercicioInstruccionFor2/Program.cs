using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleEjercicioInstruccionFor2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ulong i; // Para números enteros positivos y mayor intervalo. 
            ulong factorial = 1, numero;

            Console.WriteLine("Ingrese su número para calcular el factorial: ");
            numero = Convert.ToUInt64(Console.ReadLine());

                        
            for (i = numero; i >= 1; i--)
            {
                factorial *= i; // O, más largo: factorial = factorial * i;

            }

            Console.WriteLine($"El factorial de {numero} es: {factorial}");












        }
    }
}
