using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatricesescalonadasDeclaracionInstancia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //tipo[][] nombre = new tipo [filas][];
            double[][] ventas = new double[4][]; // Decimos con esto que estamos declarando una matriz escalonada ([][]) con 4 elementoso matrices interiores ([4][]).

            //DECLARACIÓN E INSTANCIA DE LAS MATRICES INTERNAS:

            //ventas[0] = new double[3]; // La primera semana / fila (índice 0), que tiene un tamaño de 3 elementos / columnas.
            //ventas[1] = new double[2];
            //ventas[2] = new double[4];
            //ventas[3] = new double[3];  

            //INICIALIZACIÓN de las MATRICES INTERNAS de las MATRICES ESCALONADAS:

            ventas[0] = new double[3] { 175, 100, 170 }; //De nuevo, podríamos omitrir el número de columnas o tamaño [4], dado que el compilador automáticamente cuenta el número de elementos inicializado dentro de las llaves {}.
            ventas[1] = new double[2] { 205, 120 };
            ventas[2] = new double[4] { 115, 190, 104, 130 };
            ventas[3] = new double[3] { 163, 218, 125 };

            //Si esto es muy tedioso de escribir, tambn podemos inicializar todo en la matriz principal qndo la declaramos, pero omitiendo el tamaño o número de matrices internas q va a tener y creamosun bloque de código usando llaves{} y quitando punto y coma (;):

            double[][] ventas = new double[][] //De nuevo, el compilador ya infiera el tamaño de la matriz al inicializar las matrices internas, x lo que podemos obviar la instancia: new double[][], terminaría con el operador de aignación (=).
            {
                //Todo lo que esté aquí pertenece a la matroz principal. Debemos declarar e instanciar las internas aquí:
            new double[] { 175, 100, 170 },//RECUERDA: se usa COMA aquí, no punnto y coma!!!
            new double[] { 205, 120 },
            new double[] { 115, 190, 104, 130 },
            new double[] { 163, 218, 125 }
        };// RECUERDA: punto y coma SÓLO al finalizar el bloque de código.
        }

    }
}
}
