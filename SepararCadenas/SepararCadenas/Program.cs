using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SepararCadenas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //SEPARANDO CADENAS con Split():

            string parrafo = " ¡Ah! Ésa es una de las ideas, Harry, ¿no es así, señor Gray?";//necesitamos crear una matriz que almacene las palabras de este párrafo, pero necesitamos decirle al método Split() cada cuánto se va a separar el párrafo, para eso necesitamos un "delimitador" o "separador"

            //declaramos la matriz de tupo strin unidimensional y le asignamos la devolución del método:

           /* string[] palabras = parrafo.Split(' ')*/;//le decimos a Split() que cada vez que encuentre un espacio en blanco (" ") lo use como separador y que lo guarde en un elemrnto de la matriz de "string" llamada "palabras". Los separadores seleccionados no serán incluidos en los elementos de la matriz

            //Para mostrar los elementos de la matriz almacenados:

            //Console.WriteLine(palabras[0]);
            //Console.WriteLine(palabras[1]);
            //Console.WriteLine(palabras[2]);


            // o con expresión de iteración:

            //foreach(string elemento in palabras)
            //{
            //    Console.WriteLine($"Palabras sustraída: {elemento}");
            //}

            //Podemos agregar más DELIMITADORES:
            string[] palabras = parrafo.Split(' ', ',', '.');

            foreach (string elemento in palabras)
            {
                Console.WriteLine($"Palabras sustraída: {elemento}");//Al colocar varios delimitadores, si se encuentran juntos, devolverá una cadena vacía /"empty", x eso nos muestra un espacio en blanco. Tambn nos devuelve una cadena vacía o "empty" si los delimitadores están al ppio o al final de la cadena. Si  no encuentra ningún elemento delimitador, al ejecutarse veremos la cadena original tal y como estaba, guardada en un único elemento.
            }


        }
    }
}
