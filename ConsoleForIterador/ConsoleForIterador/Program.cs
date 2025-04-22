using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleForIterador
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i;
            

            for(i = 1; i <= 10; i += 2) // Si queremos incrementar  de dos en dos, dado que los operadores de incremento y decremento solo suman o restan 1.
            {
                Console.WriteLine(i);
            }

            //Vamos a hacer una cuenta atrás del 10 al 1:

            Console.WriteLine("Vamos a probar ahora al revés del 10 al 1, de uno en uno: \n");

            int o;
            int contador = 0; // Siempre hay que asignar un valor, o no nos lo aceptará el compilador y no se ejecutará, pues dará error.

            for (o = 10; o >= 1; Console.WriteLine($"El valor de salida es: {o}. "), o--) // Así, en la tercera sección de iterador, primero muestra el valor de salida y luego realiza el decremento, va en orden.
            {
                contador++; //Para que se vaya incrementando de 1 en uno. Tambn podemos usar contador =contador +1;, que sería exactamente lo mismo, pero más largo. O tambn usando una asignación compuesta: contador += 1;
                Console.WriteLine($"Vuelta del ciclo número {contador}. ");
            }

            Console.WriteLine($"El número de vueltas que dio el ciclo fue {contador}");

            Console.WriteLine("MÁS PRÁCTICA CON EL CONTADOR: \n");

            int contador2 = 0;
            for (o = 0; o <= 20;  o += 2)
            {
                contador2++; 
                Console.WriteLine($"{o}, vuelta del ciclo número {contador2}. ");
            }

            Console.WriteLine($"El número de vueltas que dio el ciclo fue {contador2}");

            //ACUMULADOR PRÁCTICA: tenemos una caja regustradora y tenemos que sumar todas las cantidades variables de los productos vendidos durante el día.

            Console.WriteLine("PRÁCTICA CON EL ACUMULADOR: \n");

            int p;
            int acumulador = 0;
            int precio;

            for(p = 1; p <= 5; p++)
            {
                Console.Write("Ingresa el precio del producto: ");
                precio = Convert.ToInt32(Console.ReadLine());

                acumulador = acumulador + precio; // Al acumulador siempre hay que asignarle la sumade una variable: acumulador = acumulador + variable; que, más simplificado, con la asignación compuesta, es: acumulador += variable (en este caso, 'precio');
            }

            Console.WriteLine($"El total es: {acumulador}. ¡Estás forrado!");    

        }
    }
}
