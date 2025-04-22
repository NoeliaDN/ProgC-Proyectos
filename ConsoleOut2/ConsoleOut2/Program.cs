using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleOut2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Variable local a Main(argumento)
            byte numArg;
            string saludoArg;
            int numPrimoArg;

            //Invocamos al método y  mandamos los argumentos:

            Prueba(out numArg, out saludoArg, out numPrimoArg); // Debemos escribir "out" en cada una de las variables (sin incluir el tipo, que ya ha sido declarado arriba) para indicarle al método que las 3 se están enviando de esa forma.

            //Después de que el método cambió el valor, volvemos a mostrarlos:

            Console.WriteLine(numArg);
            Console.WriteLine(saludoArg);
            Console.WriteLine(numPrimoArg);

            //Efectivamente, nos muestra los valores que hemos devuelto modificando los parámetros desde el método.

        }
        static void Prueba(out byte numPa, out string saludoPa, out int numPrimoPa) // Recordemos que los parámetros deben ir en el mismo orden que los argumentos, y también debemos añadirles antes "out" a todas.
        {
            //Modificamos el valor de los parámetros:

            numPa = 20;
            saludoPa = "Hola a todos";
            numPrimoPa = 7;


        }
    }
}
