using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadenasString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Instanciando a String por medio del alias "string":

            string cadena1 = "";//es una cadedna vacía, sin caracteres
            string cadena2 = " ";//aquí no está vacía, xq el espacio es un caracter, que tiene su propio código UTF16.
            string cadena3 = "Hola, mundo";

            char[] caracteres = { 'H', 'o', 'l', 'a' };//podemos instanciar una matriz para instanciar la cadena con chars

            //Creando una instancia de String, parecido a cualquier clase:

            String cadenaDeCaracteres = new string(caracteres);//el constructor necesita caracteres Unicode que apunten a una matriz de acracteres Unicode, x eso declaramos una matriz antes ("caracteres")

            //Imprimiendo la instancia:

            Console.WriteLine(cadenaDeCaracteres);


        }
    }
}
