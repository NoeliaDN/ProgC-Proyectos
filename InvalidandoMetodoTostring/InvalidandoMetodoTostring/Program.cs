using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvalidandoMetodoTostring
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //EL MODIFICADOR "static": vamos a declarar un método dentro de nuestra clase Automovil para invocarlo y practicar con él, abajo del todo.

            //Variable local:

            bool acelerar;

            //Instanciando a la clase Automovil:

            Automovil automovil1 = new Automovil(); // Automóvil será la referencia que usaremos para llamar y referirnos al objeto, y va a contener todos los campos y métodos anteriormente declarados en la clase. Para llamarla:

            // automovil1._________;--> Una vez instanciado/ creado el objeto, ya podremos usar sus métodos y campos y al escribir "automovil1." VisualStudio nos sugerirá los campos y métodos que hemos creado ya en la clase.

            //ACCEDIENDO A LOS CAMPOS DE UNA CLASE:

            automovil1.color = "rojo"; // Usamos la referencia del objeto para acceder al campo "color" del objeto "automovil1" tipo string y asignación al color "rojo".
            automovil1.combustible = "diesel";

            //IMPRIMIENDO LOS CAMPOS:

            //Console.WriteLine($"El tipo de combustible es {automovil1.combustible}.");

            //Siempre accedemos a los elementos de una clase usando su referencia, que es la que conoce todos los elementos de la clase: campos y métodos.

            //ACCEDIENDO A LOS MÉTODOS DE UNA CLASE (invocando al método):

            automovil1.Acelerar(); //Como vemos, se hace igual que lo haríamos con un método normal, pero con la referencia al objeto ("automovil1.)

            //Si creamos una variable local en Main para recibir al método, podemos tambn hacer lo siguiente:

            acelerar = automovil1.Acelerar();

            if (acelerar)//Estamos diciendo que si el valor dentro de la variable "acelerar" es igual a true, entonces podemos mostrar este texto. Tambn podemos poner " IF (acelerar = true), pero no hace falta xq "if" evalua que lo que hay dentro es igual a TRUE.
            {
                Console.WriteLine("Acelerando correctamente");
            }

            //INVOCACION DE UN MÉTODO ESTÁTICO FUERA DE SU PROPIA CLASE:

            Automovil.Prueba(); // No se puede acceder al método static usando el nombre de referencia "automovil1", y nos pide una de tipo, x eso ponemos Automovil, remitiendo a la clase.

            //INVICANVO AL MÉTODO ToString:

            Console.WriteLine(automovil1.ToString()); // así, cada vez que un método llame al método ToString, se mostrará el mismo mensaje: El color es: rojo.


        }

        //Declaración de un campo (variable declarada directamenteen la clase):

        //int numero;


    }
    //DECLARACIÓN DE UNA CLASE (fuera de la clase anterior, dentro del namespace):

    //[modificador de acceso] [class] [identificador]

    public class Automovil 
    {
        //Campos:
        
        public string color = "rojo", modelo = "Z830", combustible, año = "1998", numPuertas = "4";//Asignamos los valores a todos los campos de manera explícita y dejamos a combustible, que se asigna por medio de la propiedad 
        //public byte año, numPuertas; --> los pasaremos a string para poder usar el método ToString, y xq no los vamos a usar para hacer operaciones aritméticas, así que nos da igual.
        public int ccMotor = 1500;

        //---------------------------------------------------------------------------------

        //ejemplo para campos inicializados con el constructor:

        private string asientos, colorTablero;
        private bool camaraTrasera;

        //CONSTRUCTOR:

        public Automovil() //al haber creado el objeto arriba con "new Automovil()", hemos invocado al constructor y x tanto se ejecutará este bloque de código:
        {
            asientos = "Piel";
            colorTablero = "Café";
            camaraTrasera = false;

            //Para mostrar estos datos, los añadiremos concatenando al método ToString (abajo)

        }

        //----------------------------------------------------------------------------------
        //Métodos:
        
        public bool Acelerar()
        {
            bool acelerar = true;
            Console.WriteLine("Acelerar");
            Prueba();
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

        //Añadimos un MÉTODO ESTÁTICO:

        public static void Prueba()
        {
            Console.WriteLine("Soy un método estático. "); //Si lo quisiéramos invocar dentro de la propia clase (Automovil), x ej, desde dentro del método Acelerar(), solo pondríamos lo que estudiamos con los métodos: Prueba();
            //Pero si quisiéramos hacerlo desde el método Main, que pertenece a una clase distinta, solo colocando el nombre nos da error, x lo que habrá que hacerlo de otra forma:por medio de la propia clase, dado que no tiene instancia/objeto al ser static y, x tanto, tampoco referente. (Mirar la invocación en el método Main, arriba)

        }

        public string Combustible
        {
            get { return combustible; } //Con esto ya podemos mostrar el valor de "combustible" en Main

            //descriptor de acceso / accessor set ( si solo tiene este, sería solo de escritura, x lo que no podemos mostrar el valor en la consola, dado que es privado, necesitamos un "get":

            set { combustible = value; }

            //MIEMBRO CON OTRA FORMA DE EXPRESIÓN:
            //miembro => expresión;

            // set => combustible = value;
        }


        //INVALIDANDO AL MÉTODO ToString:

        public override string ToString()
        {
            //string mensaje;//declarmos una variable llamada "mensaje" y le decimos que en su interior cree una cadena que dice "..." y le concatenamos a la variable "color". Contatenar: sumar cadenas.
            //mensaje = "El color es: " + color;

            //return mensaje; // dado que es un método que devuelve un tipo, tendremos que devolver el "mensaje". Entonces, volvemos a Main, donde teníamos invocado el método ToString (arriba)

            //OPCIÓN MÁS SIMPLIFICADA:

            //Tan sólo poner:

            //return "El color es: " + color;

            //Ahora vamos a invalidar el método incluyendo el formato que queremos que use:

            string mensaje;

            mensaje = "Modelo: " + modelo + "\nColor:" + color + "\nAño: " + año + "\nPuertas:" + numPuertas + "\nTipo de combustible: " + combustible + "\nMotor: " + ccMotor +"\nAsientos: " + asientos + "\nColor del tablero: " +colorTablero + "\nCámara trasera: " + camaraTrasera; //Al ejecutar, nos muestra todo junto, por lo que necesitamos un cambio de línea, x ello usaremos una SECUENCIA DE ESCAPE (de las 12 que hay en C#): \n

            return mensaje;


            
        }







        // F12 --> Para que te dirija al origen de la variable, método, clase, etc, para ver de dónde viene


    }
}

