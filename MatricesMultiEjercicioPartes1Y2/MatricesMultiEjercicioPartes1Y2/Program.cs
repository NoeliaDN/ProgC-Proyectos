using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatricesMultiEjercicioPartes1Y2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Variables:

            byte i, numAlumnos;
            byte j, salones; //añadimos la primera, dado que necesitaremos instrucciones de iteración anidadas para trabajar con matrices de 2 dimensiones; la segunda es para saber el número de clases/salones.
            double sumaCalif = 0;//(Acumulador)
            double promedio, califMin = 10, califMax = 0;

            //Pedimos el número de salones:

            Console.Write("Ingrese el número de salones: ");
            salones = Convert.ToByte(Console.ReadLine());

            //Pedimos el número de alumnos:

            Console.Write("Ingrese el número de alumnos por salón: ");
            numAlumnos = Convert.ToByte(Console.ReadLine());

            //Creamos la matriz:

            // tipo[] nombre = new tipo[tamaño]

            double[,] calif = new double[salones, numAlumnos];

            // "For" para pedir las calificaciones:

            for (i = 0; i < salones; i++) // "For" exterior para cada salón
            {
                Console.Write($"Salón {i}: \n");
                
                for(j = 0; j < numAlumnos; j++)// "For" interior para las calificaciones de cada alumno en el salón en el que estemos

                {
                    //Pedimos la calificación:

                Console.Write($"Ingrese una calificación para el alumno {j}: ");
                calif[i,j] = Convert.ToDouble(Console.ReadLine()); //Asignamos al salón blablabla, alumnos blablabla, por eso "i, j"

                //Acumulamos las calificaciones en sumaCalif:

                sumaCalif += calif[i,j];

                }
            }

            //Calculamos el promedio:

            promedio = sumaCalif / (salones * numAlumnos); // El promedio de toda la escuela, sumando todos los alumnos de todos los salones

            //Calculamos la calificación mínima:

            for (i = 0; i < salones; i++) // De nuevo, primero recorremos las filas
            {
                for (j = 0; j < numAlumnos; j++) //Luego, los alumnos
            {
                if (calif[i,j] < califMin)// Si el valor es menor le asignará ese valor a calificación mínima, si no, seguirá con el bucle de este "for".
                {
                    califMin = calif[i,j]; //Ahora caliMin tiene otro valor, el de la calif anterior, si es menor la nueva calif, se asignará, y así hasta que tengamos la mínima.
                }

            }

            }
            

            //Calculamos la calificación máxima:

            for (i = 0; i < salones; i++)
            {
                for (j = 0; j < numAlumnos; j++)
            {
                if (calif[i,j] > califMax)
                {
                    califMax = calif[i,j];
                }
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
    

