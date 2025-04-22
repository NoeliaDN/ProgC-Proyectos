 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadenasDeFormato
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //CADENAS DE FORMATO:

            //Formato compuesto:
            int numero1 = 5, numero2 = 10;
            Console.WriteLine("El número {0} es menor que el número {1}", numero1, numero2);

            string cadena1;

            cadena1 = String.Format("El valor es {0}", numero1);//num1 es un int, pero Format lo asigna a una cadena y esa cadena a una variable, así que se transforma en un strign para poder imprrimirlo en consola:
            Console.WriteLine(cadena1);

            //Interpolación de cadenas:

            //- usamos el caracter de cadena interpolada: $

            Console.WriteLine($"El primer valor es: {numero1}, y el segundo valor es {numero2}");

            //ESTRUCTRA DE UNA EXPRESIÓN DE INTERPOLACIÓN:

            // $"{"{identificador[,alineación][: formato]}"}

            String nombre = "LUIS";
            int edad = 33;
            Console.WriteLine($"Hola, soy {nombre, 10} y tengo {edad} años."); //al incluirle en la alineación un número positivo, le decimmos que queremos que el texto se alinee a la derecha, y si le ponemos un número negativo, le decimos que se alinee a la izquierda. Además, cuenta los 4 caracteres de Luis, por eso tenemos 6 espacios a la izquierda del nombre. Si ponemos -10, se alinea a la izquierda, con 6 espacios a la derecha. Si el valor de alineación Es menoR que el de la cadena mostrada no se alinea, se muestra la cadena sin alineación.

            //Usando cadenas en expresiones de interpolación:

            Console.WriteLine($"Hola, soy {"Marco",10} y tengo {"40"} años.");//Tambn podemos añadirle la alineación

            //CADENAS CON FORMATO NUMÉRICO ESTÁNDAR:

            int sueldo = 3500;//Si queremos que el sueldo se muesre como 3, 500, debemos usar la última parte de la estructura: la cade de formato
            Console.WriteLine($"Mi sueldo es de {sueldo:N}.");//no le ponemos alineación en este caso, pero le queremos dar un formato número (N), que nos permite separar los miles con comas. NO PONER ESPACIOS EN EL NOMBRE DE LA CADENA DE FORMATO!!!

           //PARA DINERO, PODEMOS USAR EL FORMATO "C" PARA MOSTRAR EL SÍMBOLO DE LA MONEDA DE ACUERDO A LA CULTURA DEL SISTEMA OPERATIVO:
           double gastos = 3500075;
            Console.WriteLine($"Mi sueldo es de {gastos:c}.");

            //Si sólo queremos mostrar X decimales, podemos usar F, seguido de la cantidad de decimales que queremos mostrar:

            double pi = 3.14159265359;
            Console.WriteLine($"El valor de pi es {pi:F2}");//F2 muestra 2 decimales

            //REDONDEA LAS CANTIDADES al nº más cercano, si el siguiente decimal es mayor o igual a 5, redondea al alza, si es menor, redondea a la baja.

            //No se pueden usar los dos formatos juntos, si se quiere mostrar el símbolo de la moneda y los decimales, se debe usar el la letra del formato y el número de decimales, x ej:

            Console.WriteLine($"Mi sueldo es de {gastos:c5}.");//con este formato, me muestra los miles con comas, la divisa  y los 5 decimales.

            //CADENAS CON FORMATO NUMÉRICO PERSONALIZADO:

            //-Marcador de posición "0": indica que se debe mostrar un dígito en esa posición, si no hay dígito, se muestra un 0:
            int numero = 123;
            Console.WriteLine($"El número es {numero:0000}");//muestra 4 dígitos, si el número tiene menos de 4 dígitos, se rellena con ceros: 0123. Si queremos mostrar decimales, se debe usar el punto y no la coma:

            Console.WriteLine($"El número es {numero:0000.00}");

            //Para usarlo para poner un separador de miles:

            int numero3 = 35000;
            Console.WriteLine($"El valor es: {numero3:0,0}");

            var numero4= 35000.4567;
            //Si queremos los dos decimales:
            Console.WriteLine($"El valor es: {numero3:0.00}");//el primer 0 representa a todos los números antes de la coma

            //Si queremos los dos decimales, ceros antes y además el separador de miles:
            Console.WriteLine($"El valor es: {numero4:000000,0.00}");

            //Marcador de posición de dígito: #, indica que se debe mostrar un dígito en esa posición, si no hay dígito, no se muestra nada:

            var numero5 = 112233;
            Console.WriteLine($"El valor es: {numero5:##-##-##}");//si queremos separar los números con guiones
            Console.WriteLine($"El valor es: {numero5:###-###}");
            Console.WriteLine($"El valor es: {numero5:###-###-###}");//vemos que si no hay un número en ese hueco, nos deja el espacio en blanco, no o rellena con nada

            //-Podemos conbinar ambos especificadores de formato en una misma cadena:
            Console.WriteLine($"El valor es: {numero5:000-###-###}");

            //IDENTIFICADR TEXTUAL @:

            //literales de cadena entrer comillas:
            string cadena = "Hola a todos";

            //literales de cadena textual
            //necesitamos el carácter "identificador textual" @:

            string rutaDirectrio = @"C:\Users\Usuario\Documents\Proyectos";//así, pasaríamos una literal de cadena simple, a una literal de cadena texctual, que se toma literalmente, por lo que las diagonales inversas se leen en el string sin ecesidad de secuencias de escape.

            //en el caso de añadir dobles comillas, no vale con usar el identificador textual @ y tendremos que usar las secuenciasde escape:
            string cadena5= @"La aclamada serie ""Juego de Tronos"" ha llegado a su fin";





        }
    }
}
