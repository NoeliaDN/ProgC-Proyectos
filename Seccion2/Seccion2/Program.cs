using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seccion2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1.Precalentar el horno");
            Console.WriteLine("2.Mezclar harina y mantequilla");
            Console.WriteLine("3.Agregar azúcar y 1 huevo");
            Console.WriteLine("4.Amasar la mezcla");
            Console.WriteLine("5.Darles forma y colocar en charola");
            Console.WriteLine("6.Hornear durante 10 minutos");

            int numeroLibros = 500;
            int libroNiños = 100;
            int librosMatematicas = 200;

            // Otra opción, con comas: int numeroLibros, int libroNiños, librosMatematicas;--> más eficiente si tenemos muchas variables del mismo tipo.

            double notaFinal; //Si queremos un resultado decimal. También: double o decimal

            numeroLibros = 500; //Se puede poner aparte o en la declaración de variables al principio.

            char salon = 'A' // siempre con comillas inversas

            string saludo = "Hola";

            bool tonto = true;

            decimal promedioExamenes = 8.5M; // si no añadimos M/m como sufijo no lo reconoce como decimal

            float promedioExamenes = 8.5f; // en el caso del float, añadimos F/f al valor numérico, de nuevo, puede ser mayúscula o minúscula
        }
    }
}
