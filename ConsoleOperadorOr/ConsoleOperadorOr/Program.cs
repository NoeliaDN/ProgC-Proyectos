using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleOperadorOr
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Operador disyuntivo u "or":

            bool p, q;

            p = false;
            q = true;



            Console.WriteLine(p || q); // Solo si ambos valores/operandos son "false", el resultado será FALSE, en cualquiera de los otros casos son TRUE.

            // EJERCICIO: un alumno solo puede conseguir la beca si tiene un promedio de 9 o una calificación final en el examen de 9.5 o más.

            // variables

            float calExamen, calPrepa;

            Console.Write("Con qué promedio concluiste tus estudios?: ");
            calPrepa = Convert.ToSingle(Console.ReadLine());

            Console.Write("¿Qué calificación sacaste en tu examen de ingreso?: ");
            calExamen = Convert.ToSingle(Console.ReadLine());

            //condición

            if (calPrepa >= 9 || calExamen >= 9.5) // También: ((calPrepa >= 9) || (calExamen >= 9.5)) --> Se puede poner cada operando en paréntesis. Esta costumbre nos ayudará a acordarnos qndo toque trabaja  con operando más complejos.
            {
                Console.WriteLine("¡Enhorabuena, conseguiste la beca! ");

            }
            else
            {
                Console.WriteLine(" Lo siento, tu beca irá para otro más listo. ");
            }



        }
    }
}
