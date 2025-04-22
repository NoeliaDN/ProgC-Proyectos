using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaColeccionGenericaQueue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //COLECCIÓN GENÉRICA "Queue":

            //Queue<T> nombre = new Queue<T>();

            Queue<char> miFila = new Queue<char>();

            //agregamos objectos al Queue:

            miFila.Enqueue('A');
            miFila.Enqueue('B');
            miFila.Enqueue('C');
            miFila.Enqueue('D');

            int i = 0;

            //Recorremos la Queue:
            foreach (char elemento in miFila)
            {
                Console.WriteLine($"{i++}. {elemento}.");
            }

            Console.WriteLine("\nDespués de agregar a (E): \n");
            miFila.Enqueue('E');

            i = 0;//Reiniciamos el valor

            //Recorremos la Queue:
            foreach (char elemento in miFila)
            {
                Console.WriteLine($"{i++}. {elemento}.");
            }

            Console.WriteLine("\nDespués de quitar un elemento: \n");
            var eliminado = miFila.Dequeue();//No hace falta parámetro, xq siempre elimina el primer elemento de la cola, pero lo ponemos para practicar asignándoloa la variable var eliminado.

            i = 0;//Reiniciamos el valor

            //Recorremos la Queue:
            foreach (char elemento in miFila)
            {
                Console.WriteLine($"{i++}. {elemento}.");
            }

            Console.WriteLine($"\nEl elemento {eliminado} fue eliminado correctamente.\n");


        }
    }
}
