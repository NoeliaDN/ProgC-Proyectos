using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolePracticaReadLine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nombre;
            string edad;
            string trabajo;

            // Preguntamos el nombre al usuario:

            Console.WriteLine("¿Cómo te llamas?:"); //También sepuede con Console.Write, pero te sale la respuesta en la misma línea.
            nombre = Console.ReadLine();


            // Saludamos al usuario

            Console.WriteLine("Hola {0}, un placer. ", nombre);

            Console.WriteLine("¿Cuál es tu edad?");
            edad = Console.ReadLine();// La edad se escribe con letras porque aún no sé cómo convertirlo a número

            Console.WriteLine("Hala, ¿¿¿ {0} ??? Madre mía, ¡qué viejales!", edad);

            Console.WriteLine("¿En qué trabajas?");
            trabajo = Console.ReadLine();

            Console.WriteLine("Hala, {0}, qué interesante, y ¡sólo tienes {1} años!. ¡Más te vale ganar bien! ¡Acuérdate de pedir subidas todos los años! ", trabajo, edad);




        }
    }
}
