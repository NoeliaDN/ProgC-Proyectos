using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleConvertPractica45
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string entrada;
            int num1 = 5, num2, resultado;

            // Tras declarar e inicializar las variables, preguntamos al usuario el número:

            Console.Write("Dame un número para sumarlo: ");
            //Se asigna a la variable tipo string "entrada":
            entrada = Console.ReadLine();

            //Convertimos la cadena en tipo int:

            num2 = Convert.ToInt32(entrada); // También podemos convertir con Parse: num2 = Int32.Parse(entrada); --> pero si hay algún error con el dato introducido el programa generará una "excepción", se detendrá la ejecución y se cerrará. Con "Convert" te mostraría un "0" y seguiría ejecutándose.

            // Para números flotantes, según la web de Microsoft, usaríamos el tipo de -NET "single" y debemos usar Parse, por lo tanto: Convert.ToSingle(); o, en el caso de "Parse", usaríamos Single.Parse();

            resultado = num1 + num2;

            // Mostramos el resultado:

            Console.Write("El resultado de la suma es: {0}. ", resultado);
        }
    }
}
