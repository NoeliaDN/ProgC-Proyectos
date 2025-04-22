using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleConvertPractica45Parte2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = 5, num2, resultado;

            //Vamos a ver una forma más sencilla de hacer lo mismo q en la parte 1, x lo que eliminamos el string.

            Console.Write("Dame un número para sumarlo a 5: ");

            num2 = Convert.ToInt32(Console.ReadLine()); // le decimos que el num2,  el que se va a sumar, es el que lea la máquina, el que escriba el usuario.

            resultado = num1 + num2;

            Console.WriteLine("El resultado de la suma es {0}. ", resultado);

            // Para hacerlo con Parse:

            Console.Write("Dame un número para sumarlo a 5: ");

            num2 = Int32.Parse(Console.ReadLine());

            resultado = num1 + num2;

            // De esta manera ahorramos código con respecto al ejemplo de la parte 1

            Console.WriteLine("El resultado de la suma es" + ": " + resultado);

            // Alternativa más eficiente de Rubén:

            Console.WriteLine($"El resultado de la suma es: {resultado}. "); // Solo se pone el símbolo del dollar "$" y la variable entre corchetes directamente sin tener que usar 0 o 1 o + como en los ejemplos anteriores .


        }
    }
}
