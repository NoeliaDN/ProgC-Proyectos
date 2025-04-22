using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace MetodoCompare
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //MÉTODO COMPARE:

            //Entero negativo (Primera cadena < Segunda cadena)
            //Cero (Primera cadena = Segunda cadena)
            //Entero positivo (Primera cadena > Segunda cadena)

            string cadena1 = "A"; 
            string cadena2 = "a";

            Console.WriteLine(String.Compare(cadena1, cadena2));

            //Vemos que nos devuelve un 1, ya que la primera cadena es mayor que la segunda.

            //Vamos a practicar con la SOBRECARGA del método Compare(String, String, CultueInfo, CompareOptions), para modificar la referencia cultural:

            string cadena3 = "z";
            string cadena4 = "ö";

            int ordenar; // para almacenar el valor que nos devuelva el método Compare.

            ordenar = String.Compare(cadena3, cadena4, new CultureInfo("de-DE"), CompareOptions.None); //especificamos referencia cultural alemana y y elegimos la opción de por defecto, no elegimos ninguna opción.

            switch (ordenar)
            {
                case -1:
                    Console.WriteLine($"{cadena3} es menor que {cadena4} según el criterio de ordenación.");
                    break;
                case 0:
                    Console.WriteLine($"{cadena3} y {cadena4} son iguales según el criterio de ordenación.");
                    break;
                case 1:
                    Console.WriteLine($"{cadena3} es mayor que {cadena4} según el criterio de ordenación.");
                    break;

            }
            //Para comprobar que funciona también en SUECO, cambiamos la referencia cultural:

            ordenar = String.Compare(cadena3, cadena4, new CultureInfo("sv-SE"), CompareOptions.None);

            switch (ordenar)
            {
                case -1:
                    Console.WriteLine($"{cadena3} es menor que {cadena4} según el criterio de ordenación.");
                    break;
                case 0:
                    Console.WriteLine($"{cadena3} y {cadena4} son iguales según el criterio de ordenación.");
                    break;
                case 1:
                    Console.WriteLine($"{cadena3} es mayor que {cadena4} según el criterio de ordenación.");
                    break;

            }
        }
    }
}
