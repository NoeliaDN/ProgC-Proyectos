using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace propiedadLength
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declaramosuna MATRIZ UNIDIMENSIONAL básica para usar "length" con ella:

            int[] numeros = new int[4] { 23, 13, 5, 6 };

            //Mostramos cuántos elementos tiene la matriz unidimensional:
            //Console.WriteLine(numeros.Length);

            Console.WriteLine(numeros.Length); // con esto, le estamos diciendo a la propiedad "length", que muestre el número de elementos que contiede la matriz., que en este caso es [4]

            // Para MATRICES MULTIDIMENSIONALES:

            double[,] ventas2D = new double[4, 3] {{100, 120, 205},
                                                     {115, 196, 300},
                                                     {157, 172, 245},
                                                     {130, 180, 281}};

            Console.WriteLine(ventas2D.Length); // Nos muestra un 12, que es el equivalente para toda la matriz en sus dos dimensiones.

            //Con las MATRICES ESCALONADAS:

            double[][] ventas = new double[][] //De nuevo, el compilador ya infiera el tamaño de la matriz al inicializar las matrices internas, x lo que podemos obviar la instancia: new double[][], terminaría con el operador de aignación (=).
            {
                //Todo lo que esté aquí pertenece a la matroz principal. Debemos declarar e instanciar las internas aquí:
            new double[] { 175, 100, 170 },//RECUERDA: se usa COMA aquí, no punnto y coma!!!
            new double[] { 205, 120 },
            new double[] { 115, 190, 104, 130 },
            new double[] { 163, 218, 125 }
            };// RECUERDA: punto y coma SÓLO al finalizar el bloque de código.

            Console.WriteLine(ventas.Length); // Nos dice 4, porque son 4 las matrices internas unidimensionales, que son los elementos de la matriz principal. Si quisiéramos que nos dijera cuántos elementos tiene cada una de esas 4 matrices, usaremos su índice:
            Console.WriteLine(ventas[0].Length);
            Console.WriteLine(ventas[1].Length);
            Console.WriteLine(ventas[2].Length);
            Console.WriteLine(ventas[3].Length);

            // Esta propiedad, junto con la instrucción "for", nos ayudará a acceder a las matrices internas de las matrices escalonadas.
        }

    }
}


