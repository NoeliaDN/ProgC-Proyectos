using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecuenciasEscape
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //SECUENCIAS DE ESCAPE DE CARACTERES:

            //Salto de línea: \n
            //Tabulación horizontal: \t
            //Secuencia de escape "null": \0
           

            Console.WriteLine("\t Lord Henry\n\n se aca\0rició la afi\0lada barba castaña y se goleó la punta de una bota con el bastón de caoba. ");

            //Alerta: \a

            Console.WriteLine("\nPresiona para confirmar: ");
            Console.ReadKey();
            Console.WriteLine("\n\a¡Aviso! Esta acción no puede cancelarse"); 
            Console.ReadKey();

            // Retorno de caro: \r
            Console.WriteLine("\n1234567\r89"); //escribe el texto hasta la cadena de escape \r y luego escribe el texto que sigue a la cadena de escape sobrescribiendo empezando los primeros caracteres

            //Retroceso: \b

            Console.WriteLine("\n1234567\b89"); //escribe el texto hasta la cadena de escape \b y luego borra el último caracter, porque regresa atrás una posición

            //Comillas dobles: \"

            Console.WriteLine("\nCita: \n\"El único modo de librarse de una tentación es caer en ella.\"");

            //Diagonal invertida: \\ --> si dejamos una sola diagonal invertida, el compilador lo tomará como un carácter de escape, y da error, porque espera que se complete

            Console.WriteLine("\nC:\\Users\\Usuario\\Documents\\Proyecto");

            //Comilla simple: \'
            Console.WriteLine("El tipo char se caracteriza por estar encerrado entre comillas simples, por ejemplo: char caracter = \'c\'");

        }
    }
}
