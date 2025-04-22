using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTarea5Ejercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte opcion;
            double resultado, radioArg, ladoArg, baseArg, alturaArg;
            

            Console.WriteLine("Escoja una opción para calcular su área: \n");

            Console.WriteLine("1. Círculo. ");
            Console.WriteLine("2. Cuadrado. ");
            Console.WriteLine("3. Triángulo. ");

            opcion = Convert.ToByte(Console.ReadLine());

            if (opcion < 1 || opcion > 3)
            {
                Console.WriteLine("Escoja una de las 3 opciones escribiendo su número. ");

            }
            else
            {
                switch (opcion)
                {
                    case 1:

                        //Pedimos datos:

                        Console.WriteLine("Ingrese el radio del círculo: ");
                        radioArg = Convert.ToDouble(Console.ReadLine());

                        //Invocamos al método dentro de WriteLine:
                        
                        Console.WriteLine($"El área de su círculo es: {Circulo(radioArg)} ");


                        break;
                    case 2:

                        //Pedimos datos:

                        Console.WriteLine("Ingrese los cm que mide uno de sus lados: ");
                        ladoArg = Convert.ToDouble(Console.ReadLine());

                        //Invocamos al método dentro de WriteLine, otra opción sería:

                        // resultado = Cuadrado(ladoArg);
                        //Console.WriteLine($"El área de su cuadrado es {resultado}");

                        Console.WriteLine($"El área de su cuadrado es {Cuadrado(ladoArg)}");


                        break;
                    case 3:
                        //Pedimos datos:

                        Console.WriteLine("Ingrese los cm que mide su base: ");
                        baseArg = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine("Ingrese su altura: ");
                        alturaArg = Convert.ToDouble(Console.ReadLine());

                        //Invocamos al método dentro de WriteLine:

                        Console.WriteLine($"El área de su triángulo es {Triangulo(baseArg, alturaArg)}");

                        break;

                }

            }


        }

        static double Circulo(double radioPa)
        {
            double resultado;

            // Calculamos el área del círculo:

            resultado = Math.PI * (radioPa * radioPa);

            //Regresamos el valor del área:

            return resultado;

        }

        static double Cuadrado (double ladoPa)
        {
            double resultado;

            // Calculamos el área del cuadrado:

            resultado = ladoPa * ladoPa;

            //Regresamos el valor del área:

            return resultado;
        }

        static double Triangulo (double basePa, double alturaPa)
        {
            double resultado;

            // Calculamos el área del triángulo:

            resultado = (basePa * alturaPa) / 2;

            //Regresamos el valor del área:

            return resultado;

        }
        
    }
}
