using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseRandom
{
    internal class Program
    {
        static void Main(string[] args)
        {
           //Instanciamos la clase Random:

            Random random = new Random();

            Console.WriteLine(random.Next());//Al ejecutar con los paréntesis vacíos, nos genera números aleatorios.  Tiene otra sobrecarga, Next(Int32.Int32)
            Console.WriteLine(random.Next(10));//Si escribimos un 10, pondremos 10 como nº máximo, dado que es otra versión del método, una sobrecarga ( Next(Int32)).

            Console.WriteLine(random.Next(20, 35));//Así activamos la segunda sobrecarga del método Next, que establece un intervalo entre el cual generará un número aleatorio


        }
    }
    }
    

