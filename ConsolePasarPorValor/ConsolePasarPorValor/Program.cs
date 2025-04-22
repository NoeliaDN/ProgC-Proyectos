using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolePasarPorValor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //PASAR POR VALOR

            //Variable local a Main(argumento)
            byte numArg;

            //Asignamos un valor:

            numArg = 10;

            Console.WriteLine(numArg);

            //Invocamos al método y mandamos al argumento numAr, para que lo reciba su parámetro y lo cambie y termine su trabajo.
            Prueba(numArg);

            //Después de que el método cambió el valor, volvemos a mostrar el argumento a ver qué pasa:

            Console.WriteLine(numArg);

            //Efectivamente, dado que el argumento envió solo una copia, él no se modifica, solo se modifica el parámetro del método Prueba() en su ámbito local. Por eso nos muestra el mismo número: 10, que es el valor que le asignamos a numArg desde Main().

            // Esto no cambiaría ni si quiera con un "return", tendríamos que asignarle numPa a numArg para que mostraran el mismo valor.

        }
        static void Prueba (byte numPa)
        {
            //Modificamos el valor del parámetro para ver qué sucede arriba:

            numPa = 20;
        }
    }
}
