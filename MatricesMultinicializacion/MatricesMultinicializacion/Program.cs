using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatricesMultinicializacion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //tipo[,]nombre = new tipo [filas, columnas] 
            double[,] ventas = new double[4, 3] { { 100, 120, 205 }, { 115, 196, 300 }, { 157, 172, 245 }, { 130, 180, 281 } };// La primera llave es solo para indicar que se va a inicializar, los pares separados por comas están separados por comas, y los valores tambn. Podemos organizarlo así para que se vea como la tabla y sea más fácil de percibir:

            //{ { 100, 120, 205 },
              //{ 115, 196, 300 },
              //{ 157, 172, 245 },
              //{ 130, 180, 281 } };

            //Recordemos que no hace falta incluir "new double [4, 3]", xq al incluir los elementos el compilador crea una instancia de 2 dimensiones con sus respectivos elementos automáticamente al ver los valires separados en llaves y comas.



            //DECLARACIÓN E INSTANCIA MATRIZ 3 DIMENSIONES:

            //tipo[,]nombre = new tipo [filas, columnas] 
            int[,,] matriz3D= new int[2, 2, 3] { { { 1, 2, 3 }, { 4, 5, 6 } }, { { 7, 8, 9 }, { 10, 11, 12 } } }; // En cada bloque salen los números en orden de la profundidad 1, 2 y 3, es decir, en orden de fila, columna y profundidad: 0,0,0; 0,0,1; 0,0,2., Luego avanzamos la línea y situaríamos: 0,1,0; 0,1,1; 0,1,2. Y no hay más filas, así que iríamos con las columnas: 0, 1, 0; 1,1, 1; 1,2,2. Etc...

            //Otra manera de verlo:

            //{ { { 1, 2, 3 }, { 4, 5, 6 } },
            //{ { 7, 8, 9 }, { 10, 11, 12 } } };


        }
    }
}
