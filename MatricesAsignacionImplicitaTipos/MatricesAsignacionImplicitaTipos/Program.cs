using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatricesAsignacionImplicitaTipos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Matriz unidimensional con asignación implícita de tipos:

            var matriz = new[] { 1, 2, 3 };// Estamos obviando los corchetes que suelen ir después del tipo y antes del nombre de la matriz y dejamos el tipo en la instancia y el tamaño tambn vacío xq el compilador lo inferirá al haber inicializado la matriz. Si pasamos el ratón sobre "matriz", veremos que el compilador nos infiere que es una matriz de tipo int, xq hemos seleccionado números enteros positivos, con 3 elementos.

            //Matriz multidimensional con asignación implícita de tipos:

            var matriz2D = new[,] {{2, 3},
                                   {4, 6}}; //Tambn omitimos corchetes cuadrados y el tipo, dado que los hemos inicializado.

            //Matriz escalonada con asignación implícita de tipos:

            var matrizJagged = new[] // --> No ponemos 2 corchetes, como acostumbramos en este tipo de matrices, dado que ya se infiere que es escalonada al inicializar 2 matrices internas en un bloque de código a continuación.
            {
                //Instanciamos a los 2 matrices unidimensionales dentro del bloque de código de la matrizde matrices o matriz escalonada / jagged:

                new[]{12, 23},
                new[]{15, 30}

            }; // No te olvides del punto y coma fiera del bloque de código!!!

            


        }
    }
}
