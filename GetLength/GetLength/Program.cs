using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetLength
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i; // Variable de control de ciclo exterior
            int j; // Variable de control de ciclo interior

            double[,] ventas2D = new double[4, 3] { { 100, 120, 205 },
                                                     {115, 196, 300},
                                                     {157, 172, 245},
                                                     {130, 180, 281} };

            //Mostramos los valores (ejercicio anterior):

            //for(i = 0; i < 4; i++)
            //{
            //    Console.WriteLine($"Fila {i}: ");

            //    for (j = 0; j < 3; j++)
            //    {
            //        Console.WriteLine(ventas2D[i, j]);

            //        //En vez de i > 4 e j < 3, podemos intentar usar la propiedad "length" : "< ventas2D.Length"; pero dará error, xq la totalidad de elementos en esta matriz bidimensional es 12, pero los índices no van del 1 al 12, sino del 0 al 3 y del 0 al 2, según filas y columnas.


            //    }
            //}

            //Para usar con "GetLength":

            //Primero, mostramos el tamaño de la primera dimensión, es decir, índice 0:

            Console.WriteLine(ventas2D.GetLength(0));//Aumentando en 1 podríamos referirnos a las siguientes dimensiones.

            //Ahora, la de la segunda:

            Console.WriteLine(ventas2D.GetLength(1));



            //Mostramos los valores usando GetLength:

            for (i = 0; i < ventas2D.GetLength(0); i++) // Para referirnos a la primera dimensión
            {
                Console.WriteLine($"Fila {i}: ");

                for (j = 0; j < ventas2D.GetLength(1); j++) // Para referirnos a la segunda dimensión
                {
                    Console.WriteLine(ventas2D[i, j]);
                }
            }
        }
    }
}
