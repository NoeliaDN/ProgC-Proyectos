using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTarea4Parte2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i, j, contadorDiv = 0;
            // "i" es la variable de control del bucle exterior que se refiere al número en el que estemos que vamos a dividir por su divisor; "j" será la variable de control del bucle interior que representa el divisor; y contadorDiv es el contador que va a contar el número de divosores posibles en el bloque interior. Si el número de divisores de cada bloque exterior es < o = a 2, los escribirá.



            for (i = 2; i <= 100; i++)// Epezamos con "i" en 2, ya que sabemos que el número 1 no es primo.
            {
                contadorDiv = 0; // Si no reiniciamos aquí el contador, se sigue acumulando y el siguiente será mayor de 2, por lo que no se escribirá el número.


                for (j = 1; j <= i; j++)
                {
                    

                    if (i % j == 0)
                    {
                        contadorDiv++;
                    }
                    

                    
                }

                if (contadorDiv <= 2) // Para ser primero tiene que tener 2 divisores, el 1 y él mismo.
                    {
                        Console.WriteLine(i);
                    }

                //if (contadorDiv <= 2)
                //    {
                //        Console.WriteLine(i);
                //    }






            }
            Console.ReadKey();




            //for (j = 2; j <= && resultado !=  0; j++)

            //{
            //    resultado = i % j;

            //    if (resultado != 0)
            //    {
            //        Console.WriteLine(i);
            //    }




            //    }

            //    Console.WriteLine();


            //}

            //Console.ReadKey();

            //int i = 6, j = 2, resultado;
            //bool noPrimo = false;
            //do
            //{
            //    resultado = i % j;
            //    j++;

            //    if (resultado == 0)
            //    {
            //        noPrimo = true;
            //    }


            //}
            //while (j < i && noPrimo == false);

            //if ( noPrimo == false)
            //{
            //    Console.WriteLine(i);
            //}

            //Console.ReadKey();

            //}
        }
    }
}


