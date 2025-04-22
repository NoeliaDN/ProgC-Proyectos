using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuscarCadenas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //BUSCANDO ELEMENTOS EN LA CADENA:

            //Usaremos los métodos de la clase String: Contains(), StartsWith(), EndsWith(), IndexOf() y LastIndexOf().

            string parrafo = "La Invasión de Yugoslavia, llamada «Operación 25» por las fuerzas del Eje, fue la campaña contra el Reino de Yugoslavia que tuvo lugar en abril de 1941, durante la Segunda Guerra Mundial.";

            Console.WriteLine($"Extracto de Wikipedia: \n\n{parrafo}\n");

            //Contains(char): devuelve un valor que indica si un caracter especificado aparece en esta cadena. Nos devuelve un booleano: true si aparece, sino false. 

            Console.WriteLine("Ingrese el texto a buscar: ");

            string buscarTexto = Console.ReadLine();

            if(parrafo.Contains(buscarTexto))//si se encuentra 
            {
                Console.WriteLine($"El texto {buscarTexto} fue encontrado. ");
            }
            else// si es false, si no se encuentra
            {
                Console.WriteLine($"El texto {buscarTexto} NO se encontró en la cadena. ");
            }

            // IMPORTANTE: Cointains() distingue entre Mayúsc. y Minúsc.!


            //StartsWith(), EndsWith(): determinan si se encuentra algo al principio o al final de la cadena, respectivamente.

            if (parrafo.EndsWith(buscarTexto))//si se encuentra 
            {
                Console.WriteLine($"El texto {buscarTexto} fue encontrado. ");
            }
            else// si es false, si no se encuentra
            {
                Console.WriteLine($"El texto {buscarTexto} NO se encontró en la cadena. ");
            }

            if (parrafo.StartsWith(buscarTexto))//si se encuentra 
            {
                Console.WriteLine($"El texto {buscarTexto} fue encontrado. ");
            }
            else// si es false, si no se encuentra
            {
                Console.WriteLine($"El texto {buscarTexto} NO se encontró en la cadena. ");
            }

            //IndexOf() y LastIndexOf(): buscan la primera y última aparición, respectivamente, de un caracter o una cadena del string original. MICROSOFT: IndexOf in dica el índice de base cero de la primera aparición de un carácter Unicode especificado o de una cadena en la instancia en cuestión, es decir, la original. El método devuelve - 1 si el carácter o cadena no se encuentran en esta instancia. LastIndex hará lo mismo, pero la ´´ultima aparición.

            string palabra = "pantalla";

            char caracterBuscado = 'a';

            //IndexOf():

            int primeraAparicion = palabra.IndexOf(caracterBuscado);//buscar la primera vez que aparece "a" en la palabra "pantalla"

            Console.WriteLine($"La primera vez que aparece el carácter ({caracterBuscado}) en la cadena ({palabra}) es en la posición ({primeraAparicion}).");

           //LastIndexOf():

            int ultimaAparicion = palabra.LastIndexOf(caracterBuscado);//buscar la primera vez que aparece "a" en la palabra "pantalla"

            Console.WriteLine($"La primera vez que aparece el carácter ({caracterBuscado}) en la cadena ({palabra}) es en la posición ({ultimaAparicion}).");


        }
    }
}
