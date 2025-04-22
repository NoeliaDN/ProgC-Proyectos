using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleConstantes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Estructura constantes: constant + tipo +identificador + = + valor;

            const int a = 10; // Las constantes deben inicializarse desde su declaración, no como pasaba con las variables, que puedes declararlas sin inicializarlas en el momento. Por lo tanto, siempre debemos asignarle un valor a las constantes.

            // Intentamos cambiar su valor

            //a = 20; 
            
            // Nos da error porque  el valor es constante y no se puede modificar como hacíamos con las variables.

            Console.WriteLine(5 + a); // Efectivamente, si loejecutamos, da 15.



        }
    }
}
