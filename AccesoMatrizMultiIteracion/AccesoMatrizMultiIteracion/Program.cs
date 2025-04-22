using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoMatrizMultiIteracion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Introducimos los valores de la misma manera para mostrarlos que con las unidimensaionales, con la particularidad deque al tener filas y columnas, tendremos que usar instrucciones de iteración que recorran unas y otras.

            //Para ello, comenzamos declarando las variables de control:

            int i; //Variable de control de ciclo exterior
            int j; //Variable de control de ciclo interior

            //tipo[,]nombre = new tipo [filas, columnas] 
            double[,] ventas = new double[4, 3] { { 100, 120, 205 },//Lo pondremos así para que sea más visual.
                                                  { 115, 196, 300 },
                                                  { 157, 172, 245 },
                                                  { 130, 180, 281 } };

            for (i = 0; i < 4; i++)// Instruccion "for" para las filas: decimos desde que i = 0, xq es qndo empiezan los índices,  y mientras que "i" sea menor que 4, es decir, hasta el índice 3, dado que hay 4 filas, le iremos sumando a i + 1.
            {
                Console.WriteLine($"Fila {i}"); // Para que nos muestre la fila por la que vamos

                for (j = 0; j < 3; j++) //Ciclo para recorrer las columnas, de la misma manera, con los índices 0, 1 y 2.
                {
                    Console.WriteLine(ventas[i, j]); //para que nos vaya mostrando las variables deuna en una según vamos recorriendo los índices asignados a "i" y "j" de uno en uno.

                }

            }






            
        }
    }
}//DECLARACIÓN E INSTANCIA MATRIZ 3 DIMENSIONES:

            //tipo[,]nombre = new tipo [filas, columnas] 
           // int[,,] matriz3D = new int[2, 2, 3] { { { 1, 2, 3 }, { 4, 5, 6 } }, { { 7, 8, 9 }, { 10, 11, 12 } } };
