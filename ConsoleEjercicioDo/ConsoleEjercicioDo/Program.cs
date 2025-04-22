using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleEjercicioDo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal num1, num2, resultado = 0M; //Le asignamos a resultado este valor con M para que sepa que es un decimal y no de error al decir el resultado al final.

            int opcion;

            do
            {

                Console.WriteLine("1. Suma. ");
                Console.WriteLine("2. Resta. ");
                Console.WriteLine("3. Multiplicación. ");
                Console.WriteLine("4. División. ");

                //Pedimos opción:

                Console.WriteLine("Eliga una opción escribiendo su número: ");
                opcion = Convert.ToInt32(Console.ReadLine());
            }
            while ((opcion < 1) || (opcion > 4));

            //Pedimos los números:

            Console.WriteLine("Dame el primer número: ");
            num1 = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Dame el segundo número: ");
            num2 = Convert.ToDecimal(Console.ReadLine());

            //Hacer la operación según la opción escogida

            switch (opcion)
            {
                case 1:
                    resultado = num1 + num2;
                    break;
                case 2:
                    resultado = num1 - num2;
                    break;
                case 3:
                    resultado = num1 * num2;
                    break;
                case 4:
                    if (num2 == 0)
                    {
                        Console.WriteLine("No se puede dividir entre 0, escoja otro número: ");
                        num2 = Convert.ToDecimal(Console.ReadLine());

                        resultado = num1 / num2;
                    }
                    else
                    {
                        resultado = num1 / num2;
                    }
                    break;

            }

            Console.WriteLine($"El resultado es: {resultado}");

            














        }



    }
}
