using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioMatricesUniParte1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Variables:

            byte i, numAlumnos;
            double sumaCalif = 0;//(Acumulador)
            double promedio, califMin = 10, califMax = 0;

            //Pedimos el número de alumnos:

            Console.WriteLine("Ingrese el número de alumnos: ");
            numAlumnos = Convert.ToByte(Console.ReadLine());

            //Creamos la matriz:

            // tipo[] nombre = new tipo[tamaño]

            double[] calif = new double[numAlumnos];

            // "For" para pedir las calificaciones:

            for (i = 0; i < numAlumnos; i++)
            {
                //Pedimos la calificación:

                Console.WriteLine("Ingrese la calificación: ");
                calif[i] = Convert.ToDouble(Console.ReadLine());

                //Acumulamos las calificaciones en sumaCalif:

                sumaCalif += calif[i];
            }

            //Calculamos el promedio:

            promedio = sumaCalif / numAlumnos;

            //Calculamos la calificación mínima:

            for (i = 0; i < numAlumnos; i++) //Ponemos que la califMin es 10 para que cuando compare pueda seguir comparando los números. Si pusiéramos 0, al comparar la nota 8, x ej., con 0, no sería menor que la califMin que es 0, x lo que dejaría de ejecutarse. Ponemos el mismo "for" que el anterior xq seguimos queriendo que pase por todos los elementos de la matriz y pare en el último, oncluído.
            {
                if (calif[i] < califMin)// Si el valor es menor le asignará ese valor a calificación mínima, si no, seguirá con el bucle de este "for".
                {
                    califMin = calif[i]; //Ahora caliMin tiene otro valor, el de la calif anterior, si es menor la nueva calif, se asignará, y así hasta que tengamos la mínima.
                }

            }

            //Calculamos la calificación máxima:

            for (i = 0; i < numAlumnos; i++)
            {
                if (calif[i] > califMax)
                {
                    califMax = calif[i];
                }
            }

            //Mostramos resultados:

            Console.WriteLine($"El promedio es: {promedio}");
            Console.WriteLine($"La calificación mínima es: {califMin}");
            Console.WriteLine($"La calificación máxima es: {califMax}");

        }
        //IMPORTANTE: tengo el ordenador en español, x lo que, aunque en programación (dentro del código) pongan los decimales con puntos, como en inglés, en la consola debo escribir los decimales con coma (,), como en español.
    }
}
