using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTarea5Ejercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal radianesArg;

            radianesArg = Convertidor(); // Práctica devolviendo un tipo

            Convertidor2(); // Práctica con un método vacío

            




        }

        static decimal Convertidor()
        {
            decimal gradosPar, radianesPar = 0;

            //Pedimos datos:

            Console.WriteLine("Ingrese los grados para convertirlos a radianes: ");
            gradosPar = Convert.ToDecimal(Console.ReadLine());

            radianesPar = (gradosPar * 3.141592653589793238M) / 180;

            //Mostrar resultado:

            Console.WriteLine($"El resultado en radianes es: {radianesPar}");

           return radianesPar;

        }
        static void Convertidor2()
        {
            decimal gradosPar, radianesPar = 0;

            //Pedimos datos:

            Console.WriteLine("Ingrese los grados para convertirlos a radianes: ");
            gradosPar = Convert.ToDecimal(Console.ReadLine());

            radianesPar = (gradosPar * 3.141592653589793238M) / 180;

            //Mostrar resultado:

            Console.WriteLine($"El resultado en radianes es: {radianesPar}");



        }
    }
}
