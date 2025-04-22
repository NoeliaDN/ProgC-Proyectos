using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleFor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Vamos a calcular el promedio o media aritméticade una clase.

            //Variables:

            double calif1, calif2, calif3, calif4, calif5, calif6, calif7, promedio;

            //Hacemos la primera petición:

            Console.WriteLine("Dame la calificación del primer alumno: ");
            calif1 = Convert.ToDouble(Console.ReadLine());

            //Hacemos la segunda petición:

            Console.WriteLine("Dame la calificación del segundo alumno: ");
            calif2 = Convert.ToDouble(Console.ReadLine());

            //Hacemos la tercera petición:

            Console.WriteLine("Dame la calificación del tercer alumno: ");
            calif3 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Dame la calificación del cuarto alumno: ");
            calif4 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Dame la calificación del quinto alumno: ");
            calif5 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Dame la calificación del sexto alumno: ");
            calif6 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Dame la calificación del séptimo alumno: ");
            calif7 = Convert.ToDouble(Console.ReadLine());


            //Calculamos el promedio:

            promedio = (calif1 + calif2 + calif3 + calif4 + calif5 + calif6 + calif7) / 7;

            //Mostramos el promedio:

            Console.WriteLine($"El promedio de tus estudiantes es: {promedio}. ");

            // Al aummentar el número de alumnos, aumenta bastante la cantidad de código que necesitamos para una tarea tan sencilla. Por eso tenemos la instrucción FOR, que usamos para ejecutar una instrucción o un conjunto de ellas mientras una expresion logica booleana, que ya ha sido especificada con anterioridad, estaba evaluando como verdadera o como TRUE. Esto va a ser siempre y cuando se conozca con antelación el número de veces que se va a estar repitiendo.

            Console.WriteLine(" PRÁCTICA CON 'for': \n");

            //Vamos a declarar una variable incrementada 10 veces en uno para practicar:

            int i; // declaramos la ariable de bucle o de control

            for (i = 1; i <= 10; i++)
            {  //1. Inicializamos la variable de control "i".
               //2. POnemos la CONDICIÓN. Al poner en la condición i <= 10, decimos que, mientras el valor de i sea gual o menos de 10, el código va a seguir ejecutándose. Sale de la última vuelta del buccle con valor 11, pero como ya es mayor de 10, no se imprime, dado que la condición da FALSE.
               //3. Ponemos la iteración, que ne este caso es incremento de 1 en sufijo, como vamos a estarusando la mayoría de laas veces.

                Console.WriteLine(i);

                
            }
            
            // Como no hay nada después del bloque de código de "for", no hace nada más.

            
        }
    }
}
