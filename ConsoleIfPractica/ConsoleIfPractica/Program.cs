using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleIfPractica
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //    if (condicion) // Por ejemplo, la condicion puede ser true o false.
            //    {
            //        //Código a ejecutar.
            //    }
            //}

            // Ejercicio:
            double num1;

            Console.WriteLine("Dame el número");
            num1 = Convert.ToDouble(Console.ReadLine());

            if (num1 > 0)
            {// Se ejecuta en caso de que la expresión se evalúe como true.
                Console.WriteLine("El número es positivo");
            }

            if (num1 < 0)
            {// Se ejecuta en caso de que la expresión se evalúe como true.
                Console.WriteLine("El número es negativo"); 

                // Si podemos 0, dado que no es ni true ni false, se finaliza el programa

            }// Si solo tenemos una sentencia, como aquí, podemos no usar {} para el acotar el código dentro de if.


        }

    }
}
