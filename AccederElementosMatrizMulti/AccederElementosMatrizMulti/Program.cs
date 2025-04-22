using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccederElementosMatrizMulti
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //tipo[,]nombre = new tipo [filas, columnas] 
            double[,] ventas = new double[4, 3];

            ventas[1, 2] = 450; // Para asignarle un valor al elementos del ídice "1, 2", es decir, primera fila, segunda columna.

            Console.WriteLine(ventas [1, 2]); // Así nos muestra el valor del índice que hemos seleccionado. Si hubiéramos inicializado la matriz, lo podríamos mostrar de la misma manera, dado que en la inicialización se asignaría el valor a cada índice y podríamos mostrar cualquiera de la misma manera. Aquí solo le hemos asignado un valor a un índice concreto para ver si lo mostraba, para no entretenernos con todos.       













            //DECLARACIÓN E INSTANCIA MATRIZ 3 DIMENSIONES:

            //tipo[,]nombre = new tipo [filas, columnas] 
           // int[,,] matriz3D = new int[2, 2, 3] { { { 1, 2, 3 }, { 4, 5, 6 } }, { { 7, 8, 9 }, { 10, 11, 12 } } }; // En cada bloque salen los números en orden de la profundidad 1, 2 y 3, es decir, en orden de fila, columna y profundidad: 0,0,0; 0,0,1; 0,0,2., Luego avanzamos la línea y situaríamos: 0,1,0; 0,1,1; 0,1,2. Y no hay más filas, así que iríamos con las columnas: 0, 1, 0; 1,1, 1; 1,2,2. Etc...

        }
    }
}
