using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleEjercicioInstruccionFor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte i, numAlumnos;
            double calificacion, sumCalif = 0, promedio;

            Console.Write("PRÁCTICA for CON acumulador:\n");

            Console.Write("Ingrese el número de alumnos: ");
            numAlumnos = Convert.ToByte(Console.ReadLine());

            for(i = 1; i <= numAlumnos; i++)
            {
                Console.WriteLine("Ingresa su calificación");
                calificacion = Convert.ToByte(Console.ReadLine());

                sumCalif += calificacion;
                              

            }
            
            promedio = sumCalif / numAlumnos;

            Console.WriteLine($"El promedio de tus alumnos es: {promedio}. ");
        }
    }
}
