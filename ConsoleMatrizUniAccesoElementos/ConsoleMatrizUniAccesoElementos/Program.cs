using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleMatrizUniAccesoElementos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            //tipo[] nombre = new tipo [tamaño];

            double[] calificaciones = new double[4]; //Aún no le hemos asignado valores

            //Asignándole un valor de 7.4 al tercer elemento de la matriz:

            //nombre [nº de índice, es decir, 1 nº menos al nº de elemento] = valor;

            calificaciones[2] = 7.4;

            //Console.WriteLine(calificaciones[2]); // Mostrar el valor del tercer elemento, índice 2

            // Tambn podemos modificar su valor:

            //double caliFinal;

            //caliFinal = calificaciones[2] - 1;

            //Console.WriteLine(caliFinal); // Mostramos en la consola para comprobar que haya modificadola calificación final restándole 1

            //Asignamos un valor al resto de elementos:

            calificaciones[0] = 9;
            calificaciones[1] = 10; 
            calificaciones[2] = 7.4; 
            calificaciones[3] = 6;

            //Como vemos, es muy repetitivo, por lo que podremos utilizar instrucciones de iteración para repetir prácticamente lo mismo.
        }
    }
}
