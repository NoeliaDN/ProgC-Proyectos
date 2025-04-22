using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTarea3Ejercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte num;
            string mes;

            Console.Write("Buenas, dime el número y te diré a qué mes conrresponde: ");
            num = Convert.ToByte(Console.ReadLine());

            

            switch (num)
            {
                case 1:
                    mes = "Enero";
                    Console.WriteLine($"El número {num} corresponde al mes de {mes}. ");

                    break;
                case 2:
                    mes = "Febrero";
                    Console.WriteLine($"El número {num} corresponde al mes de {mes}. ");

                    break;
                case 3:
                    mes = "Marzo";
                    Console.WriteLine($"El número {num} corresponde al mes de {mes}. ");

                    break;
                case 4:
                    mes = "Abril";
                    Console.WriteLine($"El número {num} corresponde al mes de {mes}. ");

                    break;
                case 5:
                    mes = "Mayo";
                    Console.WriteLine($"El número {num} corresponde al mes de {mes}. ");

                    break;
                case 6:
                    mes = "Junio";
                    Console.WriteLine($"El número {num} corresponde al mes de {mes}. ");

                    break;
                case 7:
                    mes = "Julio";
                    Console.WriteLine($"El número {num} corresponde al mes de {mes}. ");

                    break;
                case 8:
                    mes = "Agosto";
                    Console.WriteLine($"El número {num} corresponde al mes de {mes}. ");

                    break;
                case 9:
                    mes = "Septiembre";
                    Console.WriteLine($"El número {num} corresponde al mes de {mes}. ");

                    break;
                case 10:
                    mes = "Octubre";
                    Console.WriteLine($"El número {num} corresponde al mes de {mes}. ");

                    break;
                case 11:
                    mes = "Noviembre";
                    Console.WriteLine($"El número {num} corresponde al mes de {mes}. ");

                    break;
                case 12:
                    mes = "Diciembre";
                    Console.WriteLine($"El número {num} corresponde al mes de {mes}. ");
                    break;
                default:

                    {
                        Console.WriteLine("Obviamente, solo tenemos 12, meses, así que no puedes escoger otros números.");
                        break;
                    }




                   
            }

        }
    }
}
