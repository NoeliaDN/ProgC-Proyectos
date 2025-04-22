using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTarea2Ejercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nombre;
            double numLados, centimetros, resultado;

            Console.WriteLine("Buenas, ¿cómo te llamas?");
            nombre = Console.ReadLine();

            Console.WriteLine($"Encantado de conocerte, {nombre}. Hoy vamos a calcular el perímetro de un polígono regular, así que necesito que me digas algunos datos.");

            Console.WriteLine("Primero, dime el número de lados que tiene tu polígono: ");
            numLados = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("¡Perfecto! Ahora, teniendo en cuenta que en los polígonos regulares todos los lados miden lo mismo, solo necesito que me digas cuántos cm tiene uno de sus lados: ");
            centimetros = Convert.ToDouble(Console.ReadLine());

            resultado = numLados * centimetros;

            Console.WriteLine($"¡Excelente! Entonces, teniendo en cuenta que tu polígono tiene {numLados} lados y cada uno mide {centimetros} cm, el perímetro de tu polígono es: {resultado} cm.");

            Console.WriteLine($"Muchas gracias por tu participación, {nombre}. ¡Nos vemos pronto!");
            Console.ReadKey(); // Para ejecutarlo con depuración y que se quede abierto, que no se cierre después de dar el resultado. Si no lo pongo justo en la línea siguiente no me funciona O.o
        }

    }
}
