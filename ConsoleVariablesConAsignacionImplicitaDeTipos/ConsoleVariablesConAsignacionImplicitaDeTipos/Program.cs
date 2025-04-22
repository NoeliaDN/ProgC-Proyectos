using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleVariablesConAsignacionImplicitaDeTipos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //VARIABLES LOCALES CON ASIGNACIÓN IMPLÍCITA USANDO "var":

            var nombre = "Luis"; // Al asignarle un valor con comillas y texto, el compilador llega a la conclusión de que esun string.Si nos posicionamos en el nombre de la variable, ya vemos que sale string.
            var calle = "Av. 5"; // No se pueden declarar implícitamente varias variables en la misma línea, por lo que lo tendremos que hacer en líneas diferentes si queremos incluir varias variables usando la asignación implícita.
            var numero = 10; // Al ver un tipo entero, el compilador le asigna "int"
            var num2 = 2.5; // Al ver un decimal, le coloca un tipo flotante: "double".
            var letra = 'A'; //Al ver que usamos comillas y un sólo carácter, se asigna un tipo "char".


        }
    }
}
