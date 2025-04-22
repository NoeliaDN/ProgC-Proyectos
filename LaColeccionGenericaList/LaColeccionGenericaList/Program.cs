using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaColeccionGenericaList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //SINTAXIS:
            //
            //List<T> NombreLista = new List<T>();
            //Si queremos hacer una lista de persona, x ej, usaremos string en los parámetros de tipo:

            //Variables necesarias:

            string elemento;
            int opcion;
            int i; //variable de control de ciclo

            //Instancia de List:

            List<string> Personas = new List<string>();

            //Agregamos elementtos/objetos en la List:

            Personas.Add("Hugo");//Como siempre, usamos la referencia o nombre de la lista para llamar al método de la clase.
            Personas.Add("Miguel");
            Personas.Add("Diana");
            Personas.Add("Erick");

            //PARA MOSTRAR LOS ELEMENTOS SEGÚN EL ÍNDICE:

            //Console.WriteLine(Personas[1]); // Para mostrar el índice 1, como vemos, casi igual que con las matrices unidimensionales.

            //PARA MOSTRAR TODOS LOS ELEMENTOS EN ORDEN, usaremos una expresión de iteración:

            //for (i = 0; i < 4; i++)
            //{
            //    Console.WriteLine(Personas[i]);
            //}

            //Tambn podemos usar el método Count() para obtener el número de elementos que tiene la lista:

            //Console.WriteLine($"El número de elementos que tiene la lista es: {Personas.Count()}");

            //Tambn podemos usar una expresión de iteración para AGREGAR ELEMENTOS a la lista.

            //do
            //{
            //    Console.WriteLine("1. Agregar elemento. ");
            //    Console.WriteLine("2. Salir. ");
            //    opcion = Convert.ToInt32(Console.ReadLine());

            //    if (opcion == 1)
            //    {
            //        Console.Write("Ingresa el elemento a agregar a la lista: ");
            //        elemento = Console.ReadLine();

            //        Personas.Add(elemento); // Como es un bucle, podremos meter elementos hasta que queramos.
            //    }


            //} while (opcion == 1);

            //---------------------------------------------------------------------------------
            //INSERTAR UN ELEMENTO EN LA LIST usando el método Insert(Index, T):

            //Agregamos elementos para insertar:

            //Personas.Add("Hugo");
            //Personas.Add("Miguel");
            //Personas.Add("Diana");
            //Personas.Add("Erick");

            ////Insertamos un elemento en la list:

            //Personas.Insert(2, "Víctor"); //Usamos la referencia de la coleccion para invocar al método "Insert", que viene con 2 parámetros indicando el índice (2) en el que queremos insertar el elemento, y el elemento que queremos insertar ("Víctor").

            //Console.WriteLine("Información en la List actualizada: \n");
            
            

            ////INSTRUCCION "foreach" PARA RECORRER LA COLECCIÓN:
                       
            //foreach (string element in Personas) //para cada elemento de tipo string que se encuentre en nuestra coleccion "Personas", haz lo siguiente: (bloque de código)
            //{
            //    Console.WriteLine(element); //Como vemos, nos muestra los mismos elementos, pero "Victor" ahora está en el índice 2, y el que estaba antes en el índice 2 y los siguientes se desplazan un sitio hacia el final de la lista.

            //}
            
            ////QUITANDO UN ELEMENTO DE LA LIST CON EL MÉTODO RemoveAt(int index):

            //Personas.RemoveAt(4); //para quitar el elemento del índice 4

            
            //---------------------------------------------------------------------------------

            //En este caso, dado que desconocemos cuántos elementos va a agregar el usuario, tendremos que usar el método Count().

            Console.WriteLine("Información en la List: \n");

                //Mostramos los elementos de la List con instrucción "for" y "Count()":

            //for (i = 0; i < Personas.Count(); i++) // Desde que i = 0 y hasta que sea menor que el números de elementos de la lista (dado que el índice empieza en 0, el índice del último elemento será el anterior al último, así que èrfecto), se irán mostrando de 1 en 1.
            //    {
            //        Console.WriteLine(Personas[i]);
            //    }


            //INSTRUCCION "foreach" PARA RECORRER UNA COLECCIÓN, mucho mejor que "for" para esto:

            //foreach (tipo identificador in collection)
            //{

            //}

            foreach (string element in Personas) //para cada elemento de tipo string que se encuentre en nuestra coleccion "Personas", haz lo siguiente: (bloque de código)
            {
                Console.WriteLine(element);

            }

            //ENCONTRAR ELEMENTOS EN LA LISTA:

            //CON IndexOf(T):

            Console.WriteLine("Ingrese el elemento a buscar en la list: ");
            elemento = Console.ReadLine();

            //Buscar el elemento en la list:

            Console.WriteLine($"El elemento se encuentra en el índice {Personas.IndexOf(elemento)}"); //efectivamente, dice índice 2. Si ele elemento no se encuentra, dirá -1.

            //ELIMINANDO LOS ELEMENTOS DE LA LISTA CON Clear():

            Personas.Clear();

            Console.WriteLine("Información en la List: \n"); // Para comprobar que se han eliminado

            foreach (string element in Personas) //para cada elemento de tipo string que se encuentre en nuestra coleccion "Personas", haz lo siguiente: (bloque de código)
            {
                Console.WriteLine(element);

            }
        }
    }
}
