using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleSwitch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //switch ( // expresión de coincidencia )
            //    {//Estructura del swtich y su bloque de código:
            //    case opcion1:
            //        //código
            //        break;
            //        case opcion 2:
            //            //código
            //            break;
            string color;

            Console.Write("Ingrese el color (rojo, verde, azul) para ver su código RGB: ");
            color = Console.ReadLine();


            switch (color) // al igual que el "if", no tiene ";".
            {
                case "red": // IMPORTANTE: ponemos comillas porque es un "string", pero recordemos que se pone comillas simples para "char"
                case "RED":
                case "Red":

                    Console.Write($"El código para la variable {color} es: 255, 0, 0. ");
                    break;

                case "green":// Podemos poner tantos "case" como queramos en cada "sección switch", pero solo un "break" al final.
                case "Green":
                case "GREEN":

                    Console.Write($"El código para la variable {color} es: 0, 255, 0. ");
                    break;

                case "blue":
                case "BLUE":
                case "Blue":

                    Console.Write($"El código para la variable {color} es: 0 , 0,  255. ");
                    break;
                // Si ninguno de los CASE coincide con nuestro valor de coincidencia, podemos crear un CASE DEFAULT, que parecido al "else" del "if".
                default:
                    Console.WriteLine($"No se encontró el código RGB para el color {color}. Inténtalo de nuevo. ");
                    break; //Si el usuario intruduce cualquier otro color que no esté dentro de nuestros CASE, saldrá este mensaje.
            }

        }
    }
}

