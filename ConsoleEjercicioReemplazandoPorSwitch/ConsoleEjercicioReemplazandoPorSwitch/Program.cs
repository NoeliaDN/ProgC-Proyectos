using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleEjercicioReemplazandoPorSwitch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal num1, num2, resultado;
            byte opcion;

            Console.WriteLine("¡Buenas! Vamos a hacer cálculos, elige una opción\n");

            Console.WriteLine("1. Suma. ");
            Console.WriteLine("2. Resta. ");
            Console.WriteLine("3. Multiplicación. ");
            Console.WriteLine("4. División. \n");

            opcion = Convert.ToByte(Console.ReadLine());

            if (opcion > 0 && opcion < 5)
            {


                Console.Write("Dame el primer número: ");
                num1 = Convert.ToDecimal(Console.ReadLine());

                Console.Write("Dame el segundo número: ");
                num2 = Convert.ToDecimal(Console.ReadLine());

                Console.ReadKey();


                switch (opcion)
                {
                    case 1:
                        resultado = num1 + num2;
                        Console.WriteLine($"El resultado de {num1} + {num2} es: {resultado}. ");
                        Console.ReadKey();

                        break;

                    case 2:

                        resultado = num1 - num2;
                        Console.WriteLine($"El resultado de {num1} - {num2} es: {resultado}. ");
                        Console.ReadKey();
                        
                        break;
                        

                    case 3:
                        resultado = num1 * num2;
                        Console.WriteLine($"El resultado de {num1} x {num2} es: {resultado}. ");
                        Console.ReadKey();

                        break;

                       

                    case 4:


                        if (num2 == 0)
                        {
                            Console.WriteLine("No se puede dividir entre 0, mamón, coge literalmente cualquier otro número. ");

                            Console.Write("Dame el primer número: ");
                            num1 = Convert.ToDecimal(Console.ReadLine());

                            Console.Write("Dame el segundo número: \n");
                            num2 = Convert.ToDecimal(Console.ReadLine());

                            resultado = num1 / num2;
                            Console.WriteLine($"El resultado de {num1} / {num2} es: {resultado}");
                        }
                        else
                        {
                            resultado = num1 / num2;
                            Console.WriteLine($"El resultado de {num1} / {num2} es: {resultado}");


                        }
                        Console.ReadKey();

                        break;
                        //// default:

                        //     Console.Write("Obviamente, si te doy 4 opciones, es para que escojas una de esas cuatro. Ejecuta el programa de nuevo y esta vez piensa un poco, que no es difícil. ");
                        //     break;


                }
            }
            else
            {
                Console.Write("Obviamente, si te doy 4 opciones, es para que escojas una de esas cuatro. Ejecuta el programa de nuevo y esta vez piensa un poco, que no es difícil. ");
            }

        }
    }
}
