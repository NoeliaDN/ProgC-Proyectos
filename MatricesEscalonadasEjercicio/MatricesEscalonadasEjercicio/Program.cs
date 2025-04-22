using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatricesEscalonadasEjercicio
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //SOY GILIPOLLAS Y HE SOBREESCRITO AQUÍ LA TAREA 6, DADO QUE IBA DE MODIFICAR ESTE EJERCICIO: la diferencia es básicamente, que en este se hacían los cálculos para toda la escuela tambn usando matrices escalonadas, pero al ser para toda la escuela, no había necesidad de crear 3 matrices para almacenar el promedio, calif máx y calif mín de cada salón. Polo demás, está todo igual.

            //Resusamos el ejercicio anterior de calificaciones para mejorarlo:

            //Variables:

            byte i, numAlumnos;
            byte j, salones;
            double sumaCalif = 0, sumaCalifSalon;//(Acumulador)
            double promedio, califMin = 10, califMax = 0;
            double totalAlumnos = 0; //añadimos esta variable, que va a actuar como un acumulador para cada matriz interna que contenga la escalonada, es decir, para cada salón. Como usaremos un número diferente de alumnos por salón, es necesario ir acumulándolos cada vez que el usuario nos indique un número

            Console.WriteLine("\n");
            Console.WriteLine("****************************** CALCULADORA ESCOLAR *******************************\n");

            //Pedimos el número de salones:

            Console.Write("Ingrese el número de salones: ");
            salones = Convert.ToByte(Console.ReadLine());

            double[][] calif = new double[salones][]; // Creamos la nueva matriz escalonada

            Console.WriteLine(" ");


            //Pedimos el número de alumnos por salón con "for":



            for (i = 0; i < salones; i++)
            {
                Console.Write($"Ingrese el número de alumnos para el salón {i}: ");
                numAlumnos = Convert.ToByte(Console.ReadLine());

                //Instanciamos las matrices internas, es decir, los alumnos en cada salón:

                calif[i] = new double[numAlumnos]; //Para asignar a cada matriz internas / salones las calificaciones de sus alumnos.

                //Acumulamos el número de alumnos totales, para el promedio de toda la escuela:

                totalAlumnos += numAlumnos;

            }

            Console.WriteLine(" ");
            Console.WriteLine("¡Empecemos a calcular! Tan sólo tendrás que introducir unos datos :) \n ");

            //---------------------------------------------

            //Declaramos las matrices que van a almacenar los datos de cada salón:

            double[] califMinSalon = new double[salones];
            double[] califMaxSalon = new double[salones];
            double[] promedioSalon = new double[salones];




            // Pedimos la cafificación de cada alumnos de cada salón, con una instrucción "for" anidada:

            for (i = 0; i < salones; i++) // "For" exterior para cada salón
            {
                sumaCalifSalon = 0;
                califMin = 10;
                califMax = 0;

                Console.Write($"Salón {i}:\n");
                Console.WriteLine(" ");

                for (j = 0; j < calif[i].Length; j++)// "For" interior para las calificaciones de cada alumno en el salón en el que estemos

                {
                    //Pedimos la calificación:

                    Console.Write($"Ingrese una calificación para el alumno {j}: ");
                    calif[i][j] = Convert.ToDouble(Console.ReadLine()); //Asignamos al salón blablabla, alumnos blablabla, por eso "i, j", pero esta vez con la sintaxis de las matrices escalonadas: [][]

                    //Acumulamos las calificaciones en sumaCalif:

                    sumaCalif += calif[i][j];
                    sumaCalifSalon += calif[i][j];

                    if (calif[i][j] < califMin)// Si el valor es menor le asignará ese valor a calificación mínima, si no, seguirá con el bucle de este "for".
                    {
                        califMin = calif[i][j]; //Ahora caliMin tiene otro valor, el de la calif anterior, si es menor la nueva calif, se asignará, y así hasta que tengamos la mínima.


                    }

                    califMinSalon[i] = califMin;



                    if (calif[i][j] > califMax)
                    {
                        califMax = calif[i][j];


                    }

                    califMaxSalon[i] = califMax;



                    promedioSalon[i] = sumaCalifSalon / calif[i].Length;


                }
            }

            //Calculamos el promedio:


            promedio = sumaCalif / totalAlumnos; // El promedio de toda la escuela, sumando todos los alumnos de todos los salones

            //Calculamos la calificación mínima:

            for (i = 0; i < salones; i++) // De nuevo, primero recorremos las filas
            {
                for (j = 0; j < calif[i].Length; j++) //Luego, los alumnos
                {
                    if (calif[i][j] < califMin)// Si el valor es menor le asignará ese valor a calificación mínima, si no, seguirá con el bucle de este "for".
                    {
                        califMin = calif[i][j]; //Ahora caliMin tiene otro valor, el de la calif anterior, si es menor la nueva calif, se asignará, y así hasta que tengamos la mínima.
                    }

                }

            }


            //Calculamos la calificación máxima:

            for (i = 0; i < salones; i++)
            {
                for (j = 0; j < calif[i].Length; j++)
                {
                    if (calif[i][j] > califMax)
                    {
                        califMax = calif[i][j];
                    }
                }

            }
            //Mostramos las calificaciones de todos los alumnos de la escuela:

            Console.WriteLine("\n");

            for (i = 0; i < salones; i++)
            {
                Console.WriteLine("\n");

                Console.WriteLine($"Salón {i}: \n");

                for (j = 0; j < calif[i].Length; j++)
                {
                    Console.WriteLine($"El alumno {j} tiene {calif[i][j]} de calificación.");

                }
            }
            //Mostramos resultados:

            Console.WriteLine("\n");

            for (i = 0; i < salones; i++)
            {
                Console.WriteLine($"---------------------- RESULTADOS DEL SALÓN {i} --------------------\n");

                Console.WriteLine($"- El promedio es: {promedioSalon[i]}");
                Console.WriteLine($"- La calificación mínima es: {califMinSalon[i]}");
                Console.WriteLine($"- La calificación máxima es: {califMaxSalon[i]}\n");

            }

            Console.WriteLine(" ");

            Console.WriteLine($"---------------------- RESULTADOS DE TODA LA ESCUELA ------------------------\n");

            Console.WriteLine($"- El promedio es: {promedio}");
            Console.WriteLine($"- La calificación mínima es: {califMin}");
            Console.WriteLine($"- La calificación máxima es: {califMax}");

        }
        //IMPORTANTE: tengo el ordenador en español, x lo que, aunque en programación (dentro del código) pongan los decimales con puntos, como en inglés, en la consola debo escribir los decimales con coma (,), como en español.

    }
}

