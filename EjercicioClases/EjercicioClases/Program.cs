using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioClases
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Variables locales:

            string nombreArg, apellidoArg, nip;

            Console.WriteLine("¡Bienvenido a Monsters Inc.!\n");
            Console.WriteLine("Por favor, ingrese los datos que pedimos a continuación: \n");

            Console.Write("Nombre: ");
            nombreArg = Console.ReadLine();

            Console.Write("Apellido: ");
            apellidoArg = Console.ReadLine();

            Console.Write("Digite su NIP para asignarlo a su tarjeta bancaria: ");
            nip = Console.ReadLine();

            //Instanciamos a la clase y mandamos los 2 argumentos:

            Empleado empleado1 = new Empleado(nombreArg, apellidoArg);

            //Le asignamos el nip a la propiedad que corresponda:

            empleado1.Nip = nip; // Accedemos a la propiedad mediante la referencia al objeto y el nombre de la propiedad

            //Mostrar la información de nuestro objecto:

            Console.WriteLine(empleado1.ToString());


        }
    }

    class Empleado
    {
        //Campos
        private string nombre, apellido, id, locker, banco, nip;
        
        //Propiedad:
        public string Nip
        {
            set => nip = value; // al tener solo un "set" podemos usar esta expresión más corta.
                       
        }

        //Instanciamos a random aquí para no instanciarlo 3 veces, una en cada método de "Generar" o "Asignar banco":

        Random random = new Random();

        //MÉTODOS:

        //Constructor:
        public Empleado(string nombrePa, string apellidoPa)
        {
            nombre = nombrePa;
            apellido = apellidoPa;

            //Llmamos a los métodos para generar los números aleatorios que necesitemos para el id, el locker y el banco:

            id = GenerarID();
            locker = GenerarLocker();
            banco = AsignarBanco();

        }
        


        private string GenerarID()
        {
            //Instanciamos la clase Random:

            
            int i, numero;
            string id = "";

            for (i = 0; i < 10; i++)
            {
                numero = random.Next(10); // Haremos que se le asigne a id un número aleatorio menor de 10

                id += numero.ToString(); // Ese número será convertido a una cadena por el método ToString y se le asignará a ID. Actuará como un acumulador que estará concatenando a los números aleatorios que nos está dando para al final mostrarnos un número compuesto de 10 cifras.
            }

            return id;

        }

        private string GenerarLocker()
        {
           
            int i, numero;
            string locker = "";

            for (i = 0; i < 2; i++)
            {
                numero = random.Next(10); // Haremos que se le asigne a id un número aleatorio menor de 10

                locker += numero.ToString(); // Ese número será convertido a una cadena por el método ToString y se le asignará a locker. Actuará como un acumulador que estará concatenando a los números aleatorios que nos está dando para al final mostrarnos un número compuesto de 2 cifras
            }

            return locker;
        }

        private string AsignarBanco()
        {
           
            int asignarBanco;
            string banco = "";

            asignarBanco = random.Next(1, 3); // El nº aleatorio está entre 1 y 3, incluyendo al 1, pero no al 3! Por eso lo ponemos así para que nos de un número aleatorio entre 1 y 2. Si pusiéramos (1, 2), solo nos podría salir 1!

            switch (asignarBanco)
            {
                case 1:
                    banco = "Santander";

                    break;
                case 2:
                    banco = "BBVA";
                    break;
            }

            return banco;

        }
        //Invalidación del método ToString:

        public override string ToString() // Recordemos que para invalidar un método debe de ser public para poder modificar datos
        {
            string mensaje = "";

            mensaje = "Empleado: " + nombre + " " + apellido + "\nNúmero de empleado: " + id + "\nLocker nº: " + locker + "\nBanco asignado: " + banco;

            return mensaje;
        }
    }
}
