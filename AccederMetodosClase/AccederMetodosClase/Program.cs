using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccederMetodosClase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Variable local:

            bool acelerar;

            //Instanciando a la clase Automovil:

            Automovil automovil1 = new Automovil(); // Automóvil será la referencia que usaremos para llamar y referirnos al objeto, y va a contener todos los campos y métodos anteriormente declarados en la clase. Para llamarla:

            // automovil1._________;--> Una vez instanciado/ creado el objeto, ya podremos usar sus métodos y campos y al escribir "automovil1." VisualStudio nos sugerirá los campos y métodos que hemos creado ya en la clase.

            //ACCEDIENDO A LOS CAMPOS DE UNA CLASE:

            automovil1.color = "rojo"; // Usamos la referencia del objeto para acceder al campo "color" del objeto "automovil1" tipo string y asignación al color "rojo".
            automovil1.combustible = "diesel";

            //IMPRIMIENDO LOS CAMPOS:

            Console.WriteLine($"El tipo de combustible es {automovil1.combustible}.");

            //Siempre accedemos a los elementos de una clase usando su referencia, que es la que conoce todos los elementos de la clase: campos y métodos.

            //ACCEDIENDO A LOS MÉTODOS DE UNA CLASE (invocando al método):

            automovil1.Acelerar(); //Como vemos, se hace igual que lo haríamos con un método normal, pero con la referencia al objeto ("automovil1.)

            //Si creamos una variable local en Main para recibir al método, podemos tambn hacer lo siguiente:

            acelerar = automovil1.Acelerar();

            if (acelerar)//Estamos diciendo que si el valor dentro de la variable "acelerar" es igual a true, entonces podemos mostrar este texto. Tambn podemos poner " IF (acelerar = true), pero no hace falta xq "if" evalua que lo que hay dentro es igual a TRUE.
            {
                Console.WriteLine("Acelerando correctamente");
            }


        }

        //Declaración de un campo (variable declarada directamenteen la clase):

        //int numero;


    }
    //DECLARACIÓN DE UNA CLASE (fuera de la clase anterior, dentro del namespace):

    //[modificador de acceso] [class] [identificador]

    public class Automovil //Automóvil sería la clase, el plano a partir del cual nosotros podriamos crear muchos automoviles con los mismos datos y comportamientos
    {
        //Campos:
        //color, nº de puertas, combustible, motor, año, nº serie...

        public string color, modelo, combustible;
        public byte año, numPuertas;
        public int ccMotor;

        //Métodos:
        // acelerar, frenar, velocidades...

        public bool Acelerar()
        {
            bool acelerar = true;
            Console.WriteLine("Acelerar");
            return acelerar;
        }
        public bool Frenar()
        {
            bool frenar = true;
            Console.WriteLine("Frenar");
            return frenar;
        }
        public void Velocidades(ref byte velocidadPa)// No devuelve tipo, por eso void, y pasará por referencia
        {
            velocidadPa++;
            Console.WriteLine("Cambio de velocidades");
        }

        //NO USAREMOS YA EL OPERADOR STATIC, así que no profundizaremos mucho en estos métodos (acelerar, etc), solo son un ejemplo para representar la declaración de clases con sus campos y métodos en su bloque de código

        // F12 --> Para que te dirija al origen de la variable, método, clase, etc, para ver de dónde viene
    }
}
    

