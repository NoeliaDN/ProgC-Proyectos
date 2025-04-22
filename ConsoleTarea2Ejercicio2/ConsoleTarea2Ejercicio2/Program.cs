using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTarea2Ejercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nombre, sexo;
            double gradosCentigrados, gradosFarenheit;
            int codPostal;

            Console.WriteLine("¡Buenas!");

            Console.WriteLine(" ");

            Console.WriteLine("Si has iniciado esta consola es porque quieres pasar grados centígrados a grados Farenheit. Estás en el lugar correcto. Sin embargo, antes de empezar, necesitamos un par de datos para una encuesta. Tus datos serán utilizados con fines comerciales, pero con cariño. ");

            Console.WriteLine(" ");

            Console.Write("En primer lugar, nos gustaría saber su nombre: ");
            nombre = Console.ReadLine();

            Console.WriteLine(" ");

            Console.Write($"Excelente, {nombre}. En segundo lugar, necesitamos saber su sexo: ");
            sexo = Console.ReadLine();

            Console.WriteLine(" ");

            Console.Write("Y, por último, su código postal: ");
            codPostal = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(" ");

            Console.WriteLine($"Muchas gracias por tomarte este tiempo para hacer esta pequeña encuenta, {nombre}. ");

            Console.WriteLine(" ");

            Console.Write("Ahora, sin más dilación, ¡comenzamos!. Introduce el número de ºC que quieres convertir: ");

            gradosCentigrados = Convert.ToDouble(Console.ReadLine());
            gradosFarenheit = gradosCentigrados * 9d / 5d + 32d;

            Console.WriteLine(" ");

            Console.WriteLine($"¡Excelente, {nombre}! {gradosCentigrados} ºC equivalen a {gradosFarenheit} ºF");

            Console.WriteLine(" ");

            Console.Write("¡Muchas gracias por usar nuestra consola! Esperamos haber sido de gran ayuda.");


        }
    }
}
