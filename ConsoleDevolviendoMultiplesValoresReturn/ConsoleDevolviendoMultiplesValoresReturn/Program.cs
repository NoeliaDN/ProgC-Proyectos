using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleDevolviendoMultiplesValoresReturn
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Vamos a rehacer uno de los problemas anteriores usando TUPLA, es pecíficamente, con el Método Restar(), para devolver varios valores: num1, num2 y el resultado; en vez de el resultado solo. Podemos declarar laTUPLAdebajo de las variables, x ej.

            // Variables:

            byte opcion;
            decimal r; // "r" de "resultado", pues esta variable almacena el valor devuelto de Restar()
            decimal num1Arg, num2Arg; // "Arg" de "argumentos" para enviar una copia de su valor a los métodos, en este caso Multiplicar()
            //Declaramos una TUPLA:

            (decimal num1, decimal num2, decimal resultado) numeros; // En este caso no le asignamos valores entre paréntesis porque los asignará el usuario. Le damos nombre a los campos para identificarlos de mejor forma, en vez de con "Item1", "Item2", etc., si usamos "var".

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
                    numeros = Restar(); // En vez de "r" de "resultado, ahora queremos asignar los datos devueltos por return del método Restar() a la tupla declarada en Main() llamada "numeros". El compilador asignará los campos en el mismo orden en que fueron devueltos.

                    //Mostramos el resultado con la info q contiene neustra variable "r":

                    // Ahora podemos mostrar en la consola todas las variables, no solo el resultado, dado que con la TUPLA podemos devolver varios datos con return. Para ello, debemos escribirlos así:

                    Console.WriteLine($" {numeros.num1} - {numeros.num2} = {numeros.resultado}");

                    break;
                case 3:

                    // Asignamos los valores ingresados en el método IngresarNumero():

                    num1Arg = IngresarNumero("Ingrese el primer número: ");
                    num2Arg = IngresarNumero("Ingrese el segundo número: ");

                    //Invocamos al método para multiplicar los valores obtenidos:

                    Multiplicar(num1Arg, num2Arg);


                    break;
                case 4:
                    // Asignamos los valores ingresados en el método IngresarNumero():

                    num1Arg = IngresarNumero("Ingrese el primer número: ");
                    num2Arg = IngresarNumero("Ingrese el segundo número: ");

                    //Invocamos al método para dividir los valores obtenidos:

                    r = Dividir(num1Arg, num2Arg);

                    // Mostramos el resultado, con la info. que contiene "r":

                    Console.WriteLine($"El resultado de la división es: {r}");

                    break;
            }
        }// Cierre de Main-

        //Método: [modificador][tipo][identificador][parámetros]
        static void Sumar() 
        {
            
            decimal num1, num2, resultado; 

            //Pedimos el valor de ambos números:

            Console.Write("Dame el primer número: ");
            num1 = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Dame el segundo número: ");
            num2 = Convert.ToDecimal(Console.ReadLine());

            resultado = num1 + num2;

            // Mostramos el resultado:

            Console.WriteLine($" {num1} + {num2} = {resultado}");
                        
        }

        //Cómo invocar un método que nos devuelve un tipo, para la operación de resta en este caso:


        // [modificador][tipo][identificador][parámetros]

        static (decimal, decimal, decimal) Restar() 

        {
            // Tras declarar la tupla en Main(), tenemos que modificar algunas cosas tambn en este método. Dado que ya no devolvemos un solo valor, tendremos que añadir los demás tipos a la sintaxis del método Restar() entre paréntesis, como vemos arriba, en este caso 3.

            decimal num1, num2, resultado;

            //Pedimos el valor de ambos números:

            Console.Write("Dame el primer número: ");
            num1 = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Dame el segundo número: ");
            num2 = Convert.ToDecimal(Console.ReadLine());

            // Operación:

            resultado = num1 - num2;
            
            //Devolvemos múltiples tipos al autor del llamado:

            return (num1, num2, resultado); // Num1, num2 y resultado eran variables locales que solo existían en el método Restar(), pero con esto devolvemos sus valores al método Main(). El compilador convierte esas variables implícitamente a campos de tipo tupla, si nos posicionamos sobre ellos nos lo dice.
            // Ahora tenemos que ir al case 2 del switch para modificarlo y que reciban estos campos.

            
        }
        // VARIABLES CON PARÁMETROS:

        // [modificador][tipo][identificador][parámetros]--> los parámetros son las variables que van entre paréntesis al final.

        //Nombre (tipo nombreVariable, tipo nombreVariable2)

        static void Multiplicar(decimal num1Pa, decimal num2Pa) // El tipo del parámetro debe coincidir con el tipo del argumento, es decir, decimal. Usamos "Pa" de parámetros para recordar que son los parámetros ue van a recibir el valor almacenado y copiado por losargumentos de Main ().
        {
            //Variables:

            decimal resultado;
            //Multiplicación con los valores que mandaron los argumentos:

            resultado = num1Pa * num2Pa;

            Console.WriteLine($"El resultado de {num1Pa} x {num2Pa} es: {resultado}");

        }

        // [modificador][tipo][identificador][parámetros]
        static decimal Dividir(decimal num1Pa, decimal num2Pa)
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
        static decimal IngresarNumero(string peticion)
        {
            decimal numero; //Variable local al método

            // pEdimos el valor según corresponda:

            Console.Write(peticion);

            //Convertimos y asignamos:

            numero = Convert.ToDecimal(Console.ReadLine());

            //Devolvemos el valor de tipo decimal.

            return numero;
        }

    }
}
    

