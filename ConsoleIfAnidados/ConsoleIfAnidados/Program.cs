using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleIfAnidados
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Práctica de if anidados \n"); // si ponemos \n dentro del texto pone un punto y aparte, dejando una línea vacía entre esta y la siguiente linea.

            // ATAJO DE RUBÉN: Ctrl + D + K a la vez = ajustar o corregir la sangría de todo el código de la ventana, en este caso en Program.cs

            decimal num1, num2, resultado;
            byte opcion;

            Console.WriteLine("1. Suma");
            Console.WriteLine("2. Resta");
            Console.WriteLine("3. Multiplicación");
            Console.WriteLine("4. División \n");

            Console.WriteLine("Escoge una opción escribiendo su número: ");
            opcion = Convert.ToByte(Console.ReadLine());

            if (opcion != 1 && opcion != 2 && opcion != 3 && opcion != 4) // Usamos &&, la versión mejorada de & / and, para decir "y" en este contexto y ||, la alternativa de "or _and also_" para decir "o".
            {
                Console.WriteLine("Elige uno de los 4 números proporcionados");
            }
            else
            {

                Console.Write("Dame el primer número: ");
                num1 = Convert.ToDecimal(Console.ReadLine());

                Console.Write("Dame el segundo número: ");
                num2 = Convert.ToDecimal(Console.ReadLine());

                if (opcion == 1)
                {
                    resultado = num1 + num2;

                    Console.WriteLine($"El resultado de {num1} + {num2} es: {resultado}");
                }

                if (opcion == 2)
                {
                    resultado = num1 - num2;

                    Console.WriteLine($"El resultado de {num1} - {num2} es: {resultado}");
                }

                if (opcion == 3)
                {
                    resultado = num1 * num2;

                    Console.WriteLine($"El resultado de {num1} x {num2} es: {resultado}");
                }

                if (opcion == 4)
                {
                    if (num2 == 0)
                    {
                        Console.WriteLine("No se puede dividir entre 0, escoge otro. ");

                        Console.Write("Dame el primer número: ");
                        num1 = Convert.ToDecimal(Console.ReadLine());

                        Console.Write("Dame el segundo número: ");
                        num2 = Convert.ToDecimal(Console.ReadLine());

                        resultado = num1 / num2;
                        Console.WriteLine($"El resultado de {num1} / {num2} es: {resultado}");

                    }
                    else
                    {
                        resultado = num1 / num2;
                        Console.WriteLine($"El resultado de {num1} / {num2} es: {resultado}");
                    }
                    // Tambn se puede mostrar el resultado al final de todas las condiciones, en general, en vez de variarlo en cada una.  

                }
                //else
                //{
                //    Console.WriteLine("Elige uno de los 4 números proporcionados");
                //}
                // Este else no se puede poner porque entonces te salta el mensaje al final de los cálculos, y queremos que salte en el momento del error, es decir, que metan un número que no sea 1, 2, 3 o 4.
            
            // Otra opción sería anidar todos los "if" con la escalera "if else", es decir, incluyendo la opcion 2 dentro del else de la opcion 1, la opcion 3 dentro del else de la opcion 2, etc., agilizando el proceso, dado que le damos 2 opciones cada vez, en vez de 4 a la vez.

            // Estructura "else if", para saltar de "if" a "if" sin pasar por los "else" (más ágil):

            //if (opcion == 1)
            //{
            //    resultado = num1 + num2;

            //    Console.WriteLine($"El resultado de {num1} + {num2} es: {resultado}");
            //}
            //else if (opcion == 2)
            //{
            //    resultado = num1 - num2;

            //    Console.WriteLine($"El resultado de {num1} - {num2} es: {resultado}");
            //}
            //else if (opcion == 3)
            //{
            //    resultado = num1 * num2;

            //    Console.WriteLine($"El resultado de {num1} x {num2} es: {resultado}");
            //}else if (opcion == 4)
            //{
            //    if (num2 == 0)
            //    {
            //        Console.WriteLine("No se puede dividir entre 0, escoge otro. ");

            //        Console.Write("Dame el primer número: ");
            //        num1 = Convert.ToDecimal(Console.ReadLine());

            //        Console.Write("Dame el segundo número: ");
            //        num2 = Convert.ToDecimal(Console.ReadLine());

            //        resultado = num1 / num2;
            //        Console.WriteLine($"El resultado de {num1} / {num2} es: {resultado}");

            //    }
            //    else
            //    {
            //        resultado = num1 / num2;
            //        Console.WriteLine($"El resultado de {num1} / {num2} es: {resultado}");
            //    }
            }
        }
    }
    }








