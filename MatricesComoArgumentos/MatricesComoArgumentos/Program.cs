using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatricesComoArgumentos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declaramos, instanciamos e inicializamos la matriz unidimensional:

            int[] matriz = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            //Invocamos al método ImprimirMatriz:

            ImprimirMatriz(matriz); // Ponemos entre paréntesis, recordemos, la copia del argumento que queremos enviar para trabajar con él al método.

            //Declaramos matriz multidimensional:

            double[,] matriz2D = { { 1, 2 }, { 3, 4 } };

            ImprimirMatriz2D(matriz2D);
           
        }

        //Método que imprime los valores de la matriz:

        static void ImprimirMatriz(int[] matrizPa) //Void xq no nos devolverá ningún tipo y entre paréntesis vemos los parámetros, que tienen que ser del mismo tipo que los argumentos que se van a pasar.
        {
            int i; //Variable de control de ciclo

            for (i = 0; i < matrizPa.Length; i++)// Como este método nos puede servir para varias matrices y seguramente tengan distinto tamaño, usamos "length", aunque sepamos que la matriz consta de 10 elementos.
            {
                Console.WriteLine(matrizPa[i]);

                //Ahora solo queda invocar el método arriba...
            }
        }

        //Para una matriz multidimensional, sería prácticamente lo mismo, pero tendríamos que respetar los corchetes cuadrados.

        //Método que imprimelos valores de la matriz multi:

        static void ImprimirMatriz2D(double[,] matriz2DPa) // De nuevo, incluimos el mismo tipo que en el arg, "double" y los corchetes con la coma para que sepa que es una matriz de 2 dimensiones.
        {
            //Como sabemos, para matrices multidimensionales no usamos la propiedad "length", sino el método "GetLength" para usar instrucciones de iteración:

            //Variables de los ciclos:
            int i;
            int j;

            for ( i = 0; i < matriz2DPa.GetLength(0); i++)
            {
                Console.WriteLine($"Fila {i}: ");

                for (j = 0; j < matriz2DPa.GetLength(1); j++)
                {
                    Console.WriteLine(matriz2DPa[i, j] );
                }
            }
        }
    }
}
