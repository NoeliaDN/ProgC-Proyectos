using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleInstruccionIteracionWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Practiquemos intentando mostrar los números de 1 al 10.

            byte numero = 1;

            while (numero <= 10) // "Mientras el número sea menor o igual a 10, se tiene que hacer lo siguiente:"
            {
                Console.WriteLine(numero);
                numero++;
            }

            string contraseña1, contraseña2;

            Console.WriteLine("Escriba su contraseña: ");
            contraseña1 = Console.ReadLine();

            Console.WriteLine("Confirma tu contraseña: ");
            contraseña2 = Console.ReadLine();

            while (contraseña1 != contraseña2)
            {
                Console.WriteLine("No ha ingresado la misma contraseña, insértela de nuevo: ");
                contraseña2 = Console.ReadLine();
            }

            Console.WriteLine("¡Muchas gracias! Ya puede entrar en la web. ");


            Console.WriteLine("------------------------------------------------------------------\n");

            Console.WriteLine("INSTRUCCIÓN DE ITERACIÓN do: \n");

            // Volviendo con el mismo ejercicio, enseñar del 1 al 10, pero usando el bucle do-while:

            byte num = 1;

            do
                {
                Console.WriteLine(num);
                num++;


            }
            while (num <= 10) ;
        }
    }
}
