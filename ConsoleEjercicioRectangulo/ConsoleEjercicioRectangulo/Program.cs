using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleEjercicioRectangulo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double altura, ancho, area, perimetro; //Escribimos todas las variables

            //Pedimos la altura y convertimos a tipo double:

            Console.Write("Dame la altura: ");
            altura = Convert.ToDouble(Console.ReadLine()); // para convertir una cadena a tipo double

            Console.Write("Dame el ancho: ");
            ancho = Convert.ToDouble(Console.ReadLine()); // para convertir una cadena a tipo double

            // Calculamos el área:

            area = altura * ancho;

            // Calcular el perímetro:

            perimetro = 2 * (altura + ancho);

            // Mostramos los resultados en pantalla:

            Console.WriteLine("El área es: {0}. ", area);

            // O, usando la manera de Rubén, más corta:

            Console.WriteLine($"El área es: {area}.");

            // Mostramos el perímetro de la misma forma:

            Console.WriteLine("El perímetro es: {0}. ", perimetro);

            Console.WriteLine($"El perímetro es: {perimetro}. ");



        }
    }
}
