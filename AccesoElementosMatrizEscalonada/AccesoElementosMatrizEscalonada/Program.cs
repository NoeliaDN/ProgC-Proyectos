using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoElementosMatrizEscalonada
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[][] ventas = new double[4][] //De nuevo, el compilador ya infiera el tamaño de la matriz al inicializar las matrices internas, x lo que podemos obviar la instancia: new double[][], terminaría con el operador de aignación (=).
            {
                //Todo lo que esté aquí pertenece a la matroz principal. Debemos declarar e instanciar las internas aquí:
            new double[] { 175, 100, 170 },//RECUERDA: se usa COMA aquí, no punnto y coma!!!
            new double[] { 205, 120 },
            new double[] { 115, 190, 104, 130 },
            new double[] { 163, 218, 125 }
            };// RECUERDA: punto y coma SÓLO al finalizar el bloque de código.

            /*Console.WriteLine(ventas[1][0]); */// Nos muestra el 205, xq es el elementos de la fila [1] y la columna [0].

            //CON INSTRUCCIONES DE ITERACIÓN, si queremos mostrar todos los valores de la MATRIZ ESCALONADA:

            //Para ello, tendremos que hacer uso de instrucciones de iteración anidadas, x lo que declararemos las VARIABLES DE CONTROL al ppio:

            int i; // Variable de control  del ciclo exterior
            int j; //Variable de control del ciclo interior

            for (i = 0; i < ventas.Length; i++)// Para recorrer la matriz unidimensional principal hasta que sea menor que ventas.Length, es decir, que 4, pues ese es el total de elementos de la matriz.
            {
                Console.WriteLine($"Elemento: {i}");

                for (j= 0; j < ventas[i].Length; j++)// Hasta que j sea menor que el número de elementos de la matriz interior a la que corresponda "i", empezando por 0, luego 1, 2, y 3. Es decir, en la primera interna, hasta que sea menor que 3, en la segunda hasta que sea menor que 2, etc.
                {
                    Console.WriteLine(ventas[i][j]); // Para que nos muestre los elementos 1 x 1, primerode la matriz 0, luego la 1, 2 y 3.

                }

            }

        }
    }
}
