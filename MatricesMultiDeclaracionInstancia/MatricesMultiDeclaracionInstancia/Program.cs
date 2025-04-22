using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatricesMultiDeclaracionInstancia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //DECLARACIÓN DE UNA MATRIZ MULTIDIMENSIONAL de 2 dimensiones:

            //tipo[ , ] nombre = new tipo [filas, columnas];
            double[,] ventas = new double[4, 3]; //En nuestro ejemplo para calcular las ventas al mes usaríamos una dimensión de 4 elementos / semanas y otra de 3 elementos / días trabajados a la semana (viernes, sábado y domingo).

            // Para 3 dimensiones:
            double[,,] ventasAño = new double[5, 3, 3]; // Incluyendo las ventas cada mes, los 12 meses del año




        }
    }
}
