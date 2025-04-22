using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTarea4Parte1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int @base, exponente, resultado = 1;

            // Pedir datos, base y exponente
            //@base = 5;
            //exponente = 8;

            Console.WriteLine(" Dame la base: ");
            @base = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(" Dame el exponente: ");
            exponente = Convert.ToInt32(Console.ReadLine());

            
            for (int i = 1; i <= exponente ; i++)
            {
                if (i == 1)
                {
                    resultado = @base;

                }
                else
                {
                    resultado = resultado * @base;
                }
                    
            }

            Console.WriteLine($" El resultado es: {resultado}: ");
            Console.ReadKey();

        }
    }
}
