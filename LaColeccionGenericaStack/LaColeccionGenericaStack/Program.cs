using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaColeccionGenericaStack
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //LA COLECCIÓN GENÉRICA "Stack":

            //Stack<T> nombre = new Stack<T>();

            Stack<double> miPila = new Stack<double>();

            //Insertar objetos al principio del Stack:

            miPila.Push(5.9);//Toma el primer puesto con el índice 0 (representación gráfica en el cuaderno)
            miPila.Push(13.1); //Al añadirlo encima del otro elemento, pasa a ser el primero (xq el ultimo en entrar es el primero en salir, LIFO), así que pasa a ser el indice 0, y 5. 9 el 1
            miPila.Push(8.7);
            miPila.Push(3.2);
            miPila.Push(10.5);

            //Vamos a recorrer los elementos del Stack con foreach para mostrar el índice y el elemento en pantalla:

            int i = 0;//Mostrar índice

            //Mostrar la info del Stack:

            foreach(double elemento in miPila)
            {
                Console.WriteLine($"{i++}. {elemento}");
            }

            //después de insertar un elemento

            Console.WriteLine("\nDespués de insertar un elemento\n");
            miPila.Push(1.5);

            i = 0; //Reiniciamos el valor del indice

            //Mostrar la info del Stack:

            foreach (double elemento in miPila)
            {
                Console.WriteLine($"{i++}. {elemento}");
            }

            //Después de quitar el elemento:

            Console.WriteLine("\nDespués de quitar un elemento\n");
            var eliminado = miPila.Pop();//no tiene parámetros. Como vimos, elimina y nos puede devolver la variable al ppio de la lista, pero para eso necesitamos declarar una variable al ppio de Main() o aquí (var eliminado)
            i = 0; //Reiniciamos el valor del indice

            foreach (double elemento in miPila)
            {
                Console.WriteLine($"{i++}. {elemento}");
            }

            Console.WriteLine($"\nEl elemento {eliminado} ha sido eliminado con éxito. ");

            //Después de usar Peek();

            Console.WriteLine("\nDespués de usar Peek: ");
            var primerObj = miPila.Peek();
            i = 0; //Reiniciamos el valor del indice

            foreach (double elemento in miPila)
            {
                Console.WriteLine($"{i++}. {elemento}");
            }

            Console.WriteLine($"\nEl primer elemento del Stack es {primerObj}");

            //ENCONTRAR ELEMENTOS EN EL Stack:

            //Saber si el Stack contiene un elemento:

            bool contiene;
            double buscarElem;

            Console.WriteLine("\nIngresa el elemento a buscar: ");
            buscarElem = Convert.ToDouble(Console.ReadLine());

            contiene = miPila.Contains(buscarElem);

            if (contiene)// "contiene" tiene un valor booleano, así que no hace falta ponerle contiene == true, xq ya lo es
            {
                Console.WriteLine($"\nEl objeto {buscarElem} se encuentra en el Stack");
            }
            else
            {
                Console.WriteLine($"\nNo se encuentra el objeto {buscarElem} en el Stack");
            }

            Console.WriteLine($"\nEl Stack consta de {miPila.Count()} elementos. ");

            //Borrando el Stack:

            Console.WriteLine("\nDespués de borrar el Stack: ");
            miPila.Clear();

            Console.WriteLine($"\nEl Stack consta de {miPila.Count()} elementos. \n");

        }

    }
}
