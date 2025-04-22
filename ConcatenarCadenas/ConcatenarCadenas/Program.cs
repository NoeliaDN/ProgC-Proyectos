using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConcatenarCadenas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Concatenando cadenas de diversas formas:

            string texto1 = "Hola";
            string texto2 = "a";
            string texto3 = "todos";

            string textos = "Hola a todos";

            string texto5 = "Hola " + "a " + "todos. ";

            string textoLibro = "La Invasión de Yugoslavia, llamada «Operación 25» por las fuerzas del Eje, fue la campaña contra el Reino de Yugoslavia que tuvo lugar en abril de 1941, durante la Segunda Guerra Mundial.";

            Console.WriteLine(textoLibro);

            //Con el operador  +=:

            textoLibro += "La invasión concluyó once días después de iniciada, cuando el 17 de abril el Ejército Real Yugoslavo se rindió incondicionalmente.";//Se imprimen las dos cadenas seguidas:

            //Console.WriteLine(textoLibro);

            int num1 = 10;
            //Tambn podemos concatenar en vez de usar cadenas de formato
            Console.WriteLine($"\nEl valor de número 1 es: {num1}");//cadenas de formato
            Console.WriteLine("\nEl valor de número 1 es: " + num1);// concatenación

            ////---------------------------------------------


            ////Concatenando usando MÉTODOS de .NET:

            ////Método Concat(string[]), primera sobrecarga:

            string[] palabras = { "Hola", "a", "todos." };//Ésta sobrecarga de método exige un parámetro de una matriz tipo "string", x eso la creamos primero

            string texto = string.Concat(palabras);//nos devuelve la cadena tipo string con toos los elementos de la matriz concatenados

            Console.WriteLine(texto);

            //Método Concat(String, String, String), segunda sobrecarga:

            //Encadena 3 instancias de "string", que serán los parámetros requeridos para esta sobrecarga del método Concat():


            //string palabra1 = "Hola", palabra2 = "a", palabra3 = "todos";

            Console.WriteLine();
            Console.WriteLine(string.Concat(palabra1, palabra2, palabra3));



            //Sin embargo, sigue imprimiendo sin espaciaos entre las palabras, x eso necesitamos el método Join() y sus sobrecargas más sencillas:

            //Join(string, string[]):

            string[] palabras = { "Hola", "a", "todos." };//declaramos la matriz

            string textoSeparado = string.Join(" ", palabras);// el separador seleccionado es " ", x lo que deja un espacio entre los elementos de la matriz
            Console.WriteLine(textoSeparado);
            string textoSeparado = string.Join("-", palabras);//esta vez el separador es "-", x lo que todos los elementos de la matriz aparecen separados por guiones (-)
            Console.WriteLine(textoSeparado);




        }
    }
}
