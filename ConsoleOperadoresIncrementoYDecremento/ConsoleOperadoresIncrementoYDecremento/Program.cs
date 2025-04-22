using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleOperadoresIncrementoYDecremento
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i; //Operando
            i = 10;

            Console.WriteLine($"Valor inicial del operando: {i}"); // Imprimir es mostrar en la consola con WriteLine. Sale 10.

            //Incremento con sujito e imprimimos:

            Console.WriteLine($"Valor con incremento incluido : {i++}"); // Vuelve a mostrarnos 10 el resultado, sin incremento de 1.

            //Ya no estamos incrementanto, solo imprimimos:

            Console.WriteLine(i); // Ahora sí nos muestra el incremento, porque hemos usado un sufijo, x lo que primero imprimimos la variable y después muestra su incremento.

            //Incremento con el prefijo e imprimimos:

            Console.WriteLine($"Valor con incremento incluido : {++i}"); // Nos muestra directamente el valor incrementado.

            int n = 20;

            Console.WriteLine("-------------------------------------------------------");

            // Práctica con operadores de decremento:

            Console.WriteLine($"Valor inicial del operando: {n}");

            Console.WriteLine($"Valor inicial del operando: {n--}");
            Console.WriteLine(n);

            Console.WriteLine($"Valor inicial del operando: {--n}");




        }
    }
}
