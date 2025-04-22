using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleOperadoresAritmeticos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = 8;
            double num2 = 4.5;
            double resultado1;
            double resultado2;

            resultado1 = num1 + num2; //Haceos esto porque no tiene valor asignado. Tiene que ser double para que el resultado sea decimal, dado que la suma incluye decimales en el num2.

            Console.WriteLine(5 + 5 + + 2); // Al ejecutar nos muestra directamente el resultado.

            // Para hacerlo con las variables declaradas:

            Console.WriteLine(num1 + num2);

            Console.WriteLine(resultado1); // Al asignarle el valor del resultado de la suma de num1 y num2, ya nos muestra directamente el resultado tambn al ejecutar.

            // Sumando una variable y un dato expuesto explícitamente:

            resultado2 = num1 + 22;

            Console.WriteLine(resultado2);

            // Para la suma de cadenas almacenadas en variables ("concatenar"), hacemos esto:

            string saludo = "Hola";
            string nombre = "Hugo";

            Console.WriteLine(saludo + nombre); // --> El resultado semuestra junto, porque no hemos puesto espacio, pero podemos ponerlo después de HOla o antes de Hugo.

            Console.WriteLine(saludo + nombre + " ¿Cómo estás?"); // Para añadirles más datos.

            // Para poner espacios, en vez de añadirlos a los valores de las variables, podemos crear un nuevo dato, x ej:

            Console.WriteLine(saludo + " " + nombre + " " + "¿Cómo estás?");


            //Usando el operador de resta:

            Console.WriteLine(50 - 8);

            //Usando el operador de multiplicación, que es *, no x:

            Console.WriteLine(5 * 3);

            //Operación de división: dado que el resultado puede ser decimal y no va a salir xq por defecto los trata como números enteros, le tenemos que poner ".0" a los números. Aquí pongo ambos ejemplos:

            Console.WriteLine(17 / 5);

            Console.WriteLine(17.0 / 5.0); // Así el operador los tratará como datos de tipo flotante (decimales), si no los trata como enteros.

            // Práctica con los flotantes double (d), decimal, (m) y float (f) para calcular la precisión de la operación:

            Console.WriteLine(16.8f / 4.1f); // Solo muestra 6 dígitos, porque es float, llega hasta 6 dígitos solo. Si queremos más precisión, tenemos eldecimal, que es el de mayor intervalo:

            Console.WriteLine(16.8m / 4.1m); // Aquí ya vemos muchos más dígitos.

            // Para double podemos usar sufijo "d" o no. Por lo tanto, si no usamos sujijos, los tratará como double, véanse los ejemplos:

            Console.WriteLine(16.8 / 4.1); // El doble puede llegar hasta 15-17 dígitos.

            Console.WriteLine(16.8d / 4.1d);

            Console.WriteLine(5.9 % 3.1); // EL resto es el resultado restante de restar 5.9 - 3.1, lo que queda.

            // Tener en cuenta la jerarquía de operadores con o sin paréntesis:

            double resultado;

            resultado = 3.0 / (3 + 5) * 2; // Ponemos ".0" para que lo trate como decimal, no entero.

            Console.WriteLine(resultado);


        }
    }
}
