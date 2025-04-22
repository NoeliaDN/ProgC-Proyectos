using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleVariables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string saludo = "Hola";
            char caracter = 'A';
            double i = 8.9;
            int precioCamisa = 78;
            string colorCamisa = "azul";

            Console.WriteLine(saludo); /* Ya tenemos asignado el valor de "Hola" para esta variable (saludo), así que no hace falta escribirla.
            // Al escribir la variable, no el valor, no ponemos comillas */

            Console.WriteLine(caracter);

            Console.WriteLine(i);

            Console.WriteLine(precioCamisa);

            // Todo esto es para mostrar las variables en la consola.

            // {0}--> Entre corchetes mostraremos en orden las variables escritas, siendo 0 la primero, 1 la segunda, etc. 

            Console.WriteLine("El precio de la camisa es: {0}", precioCamisa);

            // Para mostrar de esta manera más de una variable, hacemos así:

            Console.WriteLine("Elprecio de la camisa es: {0} y su color es: {1}", precioCamisa, colorCamisa);
            Console.WriteLine("Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur.Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.");

        }
    }
}
