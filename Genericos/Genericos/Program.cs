using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Genericos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //EjemploGenerico<T> generico1 = new EjemploGenerico<T>();

            EjemploGenerico<string> generico1 = new EjemploGenerico<string>();
            EjemploGenerico<int> generico2 = new EjemploGenerico<int>();
        }
    }
    //GENÉRICOS SINTAXIS:

    //Primero, declaramos una clase común y corriente y la instanciamos en Main():

    class EjemploGenerico<T>//Al añadir la "T" que representa a los "parámetros de tipo" o "marcadores de posición", decimos que esta clase puede recibir parámetros de cualquier tipo. Ahora solo falta agregarlos arriba tambn, xq en la instancia debemos incluirlos tambn, pero con el tipo con el que queramos trabajar. Al ser una clase genérica, podremos instanciar potras con otros tipos ( ver arriba)
    {

    }
}
