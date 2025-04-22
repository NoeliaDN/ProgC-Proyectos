using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTarea5Ejercicio1.ConParametros
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal gradosArg, radianes;

            Console.WriteLine("Ingresa los grados para pasar a radianes: ");
            gradosArg = Convert.ToDecimal(Console.ReadLine());

            //Invocamos al método:

            radianes = Convertidor(gradosArg);

            //Mostramos el resultado:

            Console.WriteLine($"{gradosArg} grados equivalen a {radianes} radianes."); 

        }
        static decimal Convertidor(decimal gradosPa)
        {
            decimal radianes, pi = 3.141592M; // --> esta sería una posibilidad

            radianes = (pi * gradosPa) / 180;

            //También podemos usar el campo de PI reconocido por C#, cuya clase es Math:

            //decimal radianes;

            //radianes = (Math.PI * gradosPa) / 180;

            return radianes;

        }
    }
}
