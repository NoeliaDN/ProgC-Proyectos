using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolePasarPorReferencia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //PASAR POR REFERENCIA:

            

            //Variable local a Main(argumento)
            byte numArg;

            //Asignamos un valor:

            numArg = 10;

            Console.WriteLine(numArg);

            //Invocamos al método y mandamos al argumento numAr, para que lo reciba su parámetro y lo cambie y termine su trabajo. Pero para ello, tendremos que escribir "ref tambn en el parámetro, si no nos da error.

            Prueba(ref numArg);

            //Después de que el método cambió el valor, volvemos a mostrar el argumento a ver qué pasa:

            Console.WriteLine(numArg);

            //Esta vez, mediante "pasar por referencia", sí que hemos modificado su valor, como veremos en pantalla al ejecutar.

        }
        static void Prueba(ref byte numPa)
        {
            //Modificamos el valor del parámetro para ver qué sucede arriba:

            numPa = 20;
        }
    }
}

