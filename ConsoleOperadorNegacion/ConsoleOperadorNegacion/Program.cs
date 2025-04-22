using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleOperadorNegacion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool p = true;

            Console.WriteLine(p); // Nos dirá que es TRUE.
            Console.WriteLine(!p); // Nos dirá lo contrario, xq hemos puesto una negación (!), es decir, FALSE.

            // Si cambiamos el valor a "false", escribirá en la consola lo contrario, FALSE y después TRUE.

            bool bateria;

            Console.WriteLine("¿Hay batería? (true/false): ");
            bateria = Convert.ToBoolean(Console.ReadLine());

            if (!(bateria == true)) // Si dejas espacio detrás de "if" te da error!
                // Tambn podemos poner if (!bateria), que es lo mismo
            {
                Console.WriteLine("Conecte su teléfono móvil. ");
            }
            else
            {
                Console.WriteLine("No es necesario conectar el celular");
            }





        }
    }
}

