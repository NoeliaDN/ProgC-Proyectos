using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleOut
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //PRÁCTICA CON "out":



            //Variable local a Main(argumento)
            byte numArg;
            

            //NO le asignamos un valor, porque con "out" no hace falta asignarle un valor inicial al argumento para enviarlo:



            // Prueba(ref numArg); // Muestra un error con "ref" en numArg, xq dice que no se le ha asignado valor inicial, y por eso no se puede enviar como una referencia.

            //Sin embargo, si reemplazamos "ref" por "out" aquí y en el parámetros del método, deja de marcar error:

            Prueba(out numArg);

            //Después de que el método cambió el valor, volvemos a mostrar el argumento a ver qué pasa:

            Console.WriteLine(numArg);

            //Vemos que imprime el valor "20", xq hemos inicializado el argumento en el método usando un parámetro cuyo valor es, si recordamos, 20.

        }
        static void Prueba(out byte numPa)
        {
            //Modificamos el valor del parámetro para ver qué sucede arriba:

            numPa = 20;
        }
    
    }
}
