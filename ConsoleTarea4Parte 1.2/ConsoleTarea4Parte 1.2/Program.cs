using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTarea4Parte_1._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double bas, expo, resultado = 1.0d, resultadoNeg = 1.0d;
            int i = 1;

            Console.WriteLine("Dame la base: ");
            bas = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Dame el exponente: ");
            expo = Convert.ToDouble(Console.ReadLine());


            if (expo < 0)
            {
                expo = expo * -1;

                for (i = 1; i <= expo; i++)
                {
                    resultado *= bas;

                }

                resultadoNeg = (1 / resultado);


                Console.WriteLine($"El resultado es: {resultadoNeg}");

            }
            else
            {
                if (expo == 1)
                {
                    resultado = bas;

                    Console.WriteLine($"El resultado es: {resultado}");
                }
                else
                {
                    do
                    {
                        resultado = resultado * bas;
                        i++;
                    }
                    while (i <= expo);

                    Console.WriteLine($"El resultado es: {resultado}");


                }





            }
            

        }




    }
}

