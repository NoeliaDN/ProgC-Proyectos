using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleMetodosSinParametrosNiTipo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Vamos a rehacer uno de los problemas anteriores usando métodos.

            // Variables:

            byte opcion;
            decimal r; // "r" de "resultado", pues esta variable almacena el valor devuelto de Restar()
            decimal num1Arg, num2Arg; // "Arg" de "argumentos" para enviar una copia de su valor a los métodos, en este caso Multiplicar()

            do
            {
                Console.WriteLine("1. Sumar. ");
                Console.WriteLine("2. Restar. ");
                Console.WriteLine("3. Multiplicar. ");
                Console.WriteLine("4. Dividir. ");

                // Pedimos una opción:

                Console.WriteLine("Escoge una opción: ");
                opcion = Convert.ToByte(Console.ReadLine());
            }
            while (opcion < 1 || opcion > 4);

            // Hacer la operación según la escogida:

            switch (opcion)
            {
                case 1:
                    Sumar();
                    break;
                case 2:
                    r = Restar(); // A "r" se le asignará el valor que hayamos devuelto con "return" desde Restar().

                    //Mostramos el resultado con la info q contiene neustra variable "r":

                    Console.WriteLine($"El resultado de la resta es: {r}");

                    break;
                case 3:
                    Console.WriteLine("Dame el primer número: ");
                    num1Arg = Convert.ToDecimal(Console.ReadLine()); //debemos asignarlos a los argumentos creados en Main(). si no no los reconoce.

                    Console.WriteLine("Dame el segundo número: ");
                    num2Arg = Convert.ToDecimal(Console.ReadLine());

                    //Invocamos al método con parámetros Multiplicar():

                    Multiplicar(num1Arg, num2Arg);

                    break;
                case 4:
                    Console.WriteLine("Dame el primer número: ");
                    num1Arg = Convert.ToDecimal(Console.ReadLine()); //debemos asignarlos a los argumentos creados en Main(). si no no los reconoce.

                    Console.WriteLine("Dame el segundo número: ");
                    num2Arg = Convert.ToDecimal(Console.ReadLine());

                    //Invocamos al método con parámetros que devuelven un tipo: Dividir():

                    r = Dividir(num1Arg, num2Arg);

                    // Mostramos el resultado, con lainfo. que contiene "r":

                    Console.WriteLine($"El resultado de la división es: ");

                    break;
            }
        }// Cierre de Main-

        //Método: [modificador][tipo][identificador][parámetros]
        static void Sumar() //Dejamos los paréntesis vacíos xq no hay parámetros y void xq es un método "vacío", es decir, no va a devolver ninguna info.
        {
            // Variables dentro del método Sumar(), que solo existen por tanto dentro de este método (Main no sabe que existen):

            decimal num1, num2, resultado; // Estas se consideran variables locales, pues solo existen en un ámbito específico; en este caso, dentro del método Sumar().

            //Pedimos el valor de ambos números:

            Console.Write("Dame el primer número: ");
            num1 = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Dame el segundo número: ");
            num2 = Convert.ToDecimal(Console.ReadLine());

            resultado = num1 + num2;

            // Mostramos el resultado:

            Console.WriteLine($" {num1} + {num2} = {resultado}");

            // Si ejecutamos el programa, no pasará nada xxq no hemos invocado al método. POr eso escribiremos Sumar(); en case 1 para invcarlo.

            // Hasta aquí cómo invocar un método sin parámetros ni tipo.
        }

        //Cómo invocar un método que nos devuelve un tipo, para la operación de resta en este caso:


        // [modificador][tipo][identificador][parámetros]

        static decimal Restar() // Como vamos a devolver una informacion de tipo flotante decimal, ya no escribimos void (ningún tipo de info), si no "decimal"

        {
            decimal num1, num2, resultado;

            //Pedimos el valor de ambos números:

            Console.Write("Dame el primer número: ");
            num1 = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Dame el segundo número: ");
            num2 = Convert.ToDecimal(Console.ReadLine());

            resultado = num1 - num2;

            //Devolver información: para ello, tenemos que llamar con una palabra clave (KeyWord) al autor de la invocación del método, en este caso Main. Así devolveremos el resultado, en vez de mostrarlo dentro del método Restar().

            //Devolvemos un tipo al autor del llamado:

            return resultado;

            // Ahora sollo tenemos que invocar el método Restar() en el case 2, pero dado que esta vez devolvemos un tipo de info, lo haremos ligeramente diferente, como veremos arriba.

        }
        // VARIABLES CON PARÁMETROS:

        // [modificador][tipo][identificador][parámetros]--> los parámetros son las variables que van entre paréntesis al final.

        //Nombre (tipo nombreVariable, tipo nombreVariable2)

        static void Multiplicar (decimal num1Pa, decimal num2Pa) // El tipo del parámetro debe coincidir con el tipo del argumento, es decir, decimal. Usamos "Pa" de parámetros para recordar que son los parámetros ue van a recibir el valor almacenado y copiado por losargumentos de Main ().
        {
            //Variables:

            decimal resultado;
            //Multiplicación con los valores que mandaron los argumentos:

            resultado = num1Pa * num2Pa;

                Console.WriteLine($"El resultado de {num1Pa} x {num2Pa} es: {resultado}");

        }

        // [modificador][tipo][identificador][parámetros]
        static decimal Dividir (decimal num1Pa, decimal num2Pa)
        {
            decimal resultado;

            
            if (num2Pa != 0)
            {
                //Division con los valores que mandaron los argumentos:

                resultado = num1Pa / num2Pa;

            }
            else
            {      
                Console.WriteLine("No es posible dividir entre 0. ");
                resultado = 0;
            }

                
            return resultado;
        }






    }
}

