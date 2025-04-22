using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoElementosMatrizIteracion1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //tipo[] nombre = new tipo [tamaño];

            string [] nombres = new string [3];

            //Colocamos valores en los 3 elementos:

            nombres[0] = "Sandra";
            nombres[1] = "Pedro";
            nombres[2] = "Carmen";

            //Queremos mostrar todos los valores, pero no 1 x 1, por lo que no usaremos Console.WriteLine, si no una instrucción "for":

            byte i; // Declaramos la variable de control del ciclo

            for (i = 0; i <= 2; i++) // Desde que i = 0, mientras que i sea menor o igual a 0, se sumará 1. Tambn podemos poner hasta que i>3, q es lo mismo. Queremos que vaya de uno en uno contando los elementos de la matroz sin que se salte ninguno.
            {
                Console.WriteLine(nombres[i]); // Mostramos el valor de "i" porque ese será el índice del elemento que queremos mostrar, que aumentará en 1 en cada vuelta.

            }


        }
    }
}
