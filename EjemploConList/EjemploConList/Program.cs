using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploConList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Vaiables necesarias

            int opcion, indice;
            string alumno; //recibe el nombre del alumno para agregar o eliminar de la list


            //Instancia de la List:

            List<string> alumnos = new List<string>(); // la referencia siempre en NOTACIÓN CAMELLO!!!

            do
            {
                Console.Clear();

                Console.WriteLine("\n1. Agregar estudiante.");
                Console.WriteLine("2. Eliminar estudiante.");
                Console.WriteLine("3. Mostrar estudiante.");
                Console.WriteLine("4. Buscar por nombre.");

                //Escoger una opción:

                Console.WriteLine("\nEscoja una opcion: ");
                opcion = Convert.ToInt32(Console.ReadLine());

                Console.Clear();

                switch (opcion)
                {
                    case 1:

                        Console.WriteLine("Ingrese el nombre del alumno: ");
                        alumno = Console.ReadLine();

                        alumnos.Add(alumno);
                        break;

                    case 2:

                        Console.WriteLine("Seleccione el número del alumno que quiere eliminar: ");
                        indice = Convert.ToInt32(Console.ReadLine());

                        indice--;//REducción a en 1 a índice, xq el usuario no sabe que el índice empieza en 0.

                        if (indice >= alumnos.Count() || indice < 0)// Si introducimos un número superior al número de alumnos existentes en la lista, mostrará el siguiente mensaje
                        {
                            Console.WriteLine("El alumno no existe. ");
                        }
                        else
                        {
                            string alumnoElim = alumnos[indice]; //Creamos la variable y la asociamos al índice que hayamos escogido para luego mostrarla en la consola diciendo qué alumno se ha eliminado.
                            alumnos.RemoveAt(indice);//Quitamos al alumno de la LIst

                            Console.WriteLine($"{alumnoElim} se ha eliminado correctamente");
                        }

                        Console.Write("\n Presione cualquier tecla para volver al ´menú: ");
                        Console.ReadKey(); //Porque si no no da tiempo a ver el mensaje, pasará directamente  al menú de nuevo y borrará todo lo escrito con Clear()


                        break;

                    case 3:
                        int i = 1;//Nos sirve para mostrar el índice de los alumnos

                        foreach (string estudiante in alumnos)
                        {
                            Console.WriteLine($" {i++}. {estudiante}");
                        }

                        Console.Write("\n Presione cualquier tecla para volver al ´menú: ");
                        Console.ReadKey();

                        break;

                    case 4:
                        string encontrarAlum; //Va a recibir el nombre de la lista, si es que lo encuentra
                        int j; //número de lista

                        Console.WriteLine("Ingrese el nombre del estudiante a buscar: ");
                        alumno = Console.ReadLine();

                        //Verficar si el elemento / alumno está en la lista:

                        if (alumnos.IndexOf(alumno) >= 0)//Si el índice del alumno escogido es mayor que 0, hacer lo siguiente:

                        {
                            encontrarAlum = alumnos[alumnos.IndexOf(alumno)];//Alumnos [índice]

                            j = alumnos.IndexOf(alumno) + 1; //índice + 1 para mostrarlo en la consola como número de lista

                            Console.WriteLine($"El estudiante {encontrarAlum} se encuentra en el número de lista {j}. ");


                        }
                        else
                        {
                            Console.WriteLine($"El estudiante {alumno} no se encuentra en el sistema. ");


                        }

                        Console.Write("\n Presione cualquier tecla para volver al ´menú: ");
                        Console.ReadKey();


                        break;
                }

            }
            while (opcion >= 1 && opcion <= 4);

        }
    }
}
