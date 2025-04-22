using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleInicializacionMatrizUni
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // INICIALIZACIÓN DE UNA MATRIZ UNIDIMENSIONAL:

            //tipo[] nombre = new tipo [tamaño];

            double[] calificaciones = new double[4] { 9, 10, 7.4, 6 }; // Si obviamos el número que indica el tamaño entre "[]" o incluso toda la creación de la instancia/objeto ( new double []), teniendo ya los valores de los elementos, el compilador ya crea la instancia implícitamente, dado que reconoce que es un objeto de 4 elementos tipo "double". Por ello, podríamos poner :

            //double[] calificaciones = new double[] { 9, 10, 7.4, 6 };

            //o incluso:

            //double[] calificaciones = { 9, 10, 7.4, 6 };

            //Declaración de otra matriz:

            int[] numeros; // Al declarar una variable solo, sin "instanciarla" (crear el objeto tipo matriz), el compilador no sabe el tamaño que va a ocupar xq todavía no se lo hemos dado, x lo que aún no se reserva espacio en memoria para ella. Por eso debemos instanciarlas siempre con el operador new.

            // Al crear una variable común, sin embargo, aunque no la inicialicemos, sabemos lo que va a ocupar por su tipo. Por ej: "int" ocupa 32bits, x lo que se reserva ese espacio.

            // En vez de crear la instancia como hemos visto arriba, podemos añadir a la previa declaración lo siguiente:

            //Instancia (creación del objeto) e inicialización de la estancia:

            numeros = new int[] { 5, 3, 1 };




        }
    }
}
