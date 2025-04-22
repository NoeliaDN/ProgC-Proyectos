using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleMatricesUnidimensionales
{
    internal class Program
    {
        static void Main(string[] args)
        {

            

            // DECLARACIÓN DE UNA MATRIZ:
             
            // tipo[] nombre = new tipo [tamaño o nº de elementos/variables dentro de la matriz];

            //Para nuestro ejercicio vamos a declarar una matriz de tipo "double":

            double[] calificaciones = new double [4]; // Si no colocamos el tamaño da error.

            //EJERCICIO:

            //Declarar 3 matrices que nos pone en pantalla:

            //tipostring, llamada "nombres" y de tamaño 5
            string[] nombres = new string [5];

            //tipo int, llamada "números" y de tamaño 10
            int[] numeros = new int [10];

            //tipo byte, llamada "datos" y de tamaño 7
            byte[] datos = new byte[7];

            //Tambn podemos preguntarle al usuario el tamaño de la matriz:
                        
            byte tamaño;

            Console.WriteLine("¿De qué tamaño será la matriz?");
            tamaño = Convert.ToByte(Console.ReadLine());

            int[] primos = new int[tamaño];




        }
    }
}
