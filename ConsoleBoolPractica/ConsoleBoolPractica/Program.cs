using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleBoolPractica
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Para asignar un valor a un booleano:

            //  bool decision;
            //  decision = true;

            Console.WriteLine("Operadores de igualdad y desigualdad:");

            // No hace falta introducir un valor, como veremos en los ejemplos siguientes:

            Console.WriteLine(6 == 6); // SI ejecutamos el programa veremos que nos pone "true", porque 6 es 6. Sin embargo, si introducimos valores variables distintas con valores distintos:

            int a = 30, b = 20;
            Console.WriteLine(a == b); //Nos dirá que es "false".

            // Operadores de deigualdad: !=

            Console.WriteLine(b != a); // Nos dice que es "true" que esos números no son iguales.

            // Bool se utiliza sobre todo para valores numéricos, pero se puede utilizar para cadenas, etc., tambn.

            Console.WriteLine("Operadores de comparación:");

            //Operadores de comparación:

            Console.WriteLine(8 < 3.5); // false
            Console.WriteLine(8 > 3.5); // true
            Console.WriteLine(8 >= 3.5); // true
            Console.WriteLine(8 <= 3.5); // false
            Console.WriteLine((8 -7) > 3.5); // false, por jerarquía de losoperadores




        }


    }
}
