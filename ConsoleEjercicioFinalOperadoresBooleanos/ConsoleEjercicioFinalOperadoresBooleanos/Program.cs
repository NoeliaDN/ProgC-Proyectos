using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleEjercicioFinalOperadoresBooleanos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float energia;
            bool propulsorIzq, propulsorDer;

            //Obtenemos los datos:

            Console.Write("¿Cuánta gasolina tiene el cohete (%)?: ");
            energia = Convert.ToSingle(Console.ReadLine());

            Console.Write("¿Funciona el propulsor izquierdo? (true/false): ");
            propulsorIzq = Convert.ToBoolean(Console.ReadLine());

            Console.Write("¿Funciona el propulsor derecho (true/false)?: ");
            propulsorDer = Convert.ToBoolean(Console.ReadLine());

            // condición
            if (energia > 100) // La ponemos aquí en vez de dentro del else para que si se da esta condición no siga leyendo código y ejecutando cosas innecesarias. De esta manera, si metes más de 100% de gasolina el "else if" no se ejecutará.
            {
                Console.WriteLine("Recuerde no exceder los límites de gasolina o el cohete no podrá despegar.");
            }
            else if ((((propulsorIzq == true) && (propulsorDer == true)) && ((energia >= 75) && (energia <= 100)) || (((propulsorIzq == false) && (propulsorDer == true)) && energia == 100))) // El profesor lo hizo como que cualquiera de los propulsores podría no ser true, yo como que solo el izq puede estar false, si no no despega.
            {
                Console.WriteLine(" Enhorabuena, ¡el cohete puede despegar! ");
            }

            else
            {
                Console.WriteLine("Lo siento, no es seguro despegar. ");
                                
            }




        }
    }
}
