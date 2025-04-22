using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Propiedades
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // PROPIEDADES:

            //Para practicar con las propiedades, volveremos a todos los campos de la clase Automovil "private" (abajo).

           
            //Variable local:

           // bool acelerar;

            //Instanciando a la clase Automovil:

            Automovil automovil1 = new Automovil(); 

            
            //MOSTRANDO EL CAMPO PRIVADO "color" usando "get":
            
            Console.WriteLine($"El color es: {automovil1.Color} "); //No nos deja usar el campo (en minuscula, notacion camello), xq sigue siendo privado, pero nos deja usar la propiedad ( en mayusc, notacion pascal).

            //Nos muestra el mensaje xq le hemos asignado el color dentro de la propiedad, pero no le podemos asignar a la propiedad ese color desde Main, xq nos dice que es solo de lectura, dado que de momento solo tenemos un "get", sin "set".

            //ASIGNANDO UN VALOR A CAMPO PRIVADO ( con "set") Y MOSTRÁNDOLO(con "get":

            automovil1.Combustible = "diesel"; // Estaríamos asignando un argumento para que lo reciba el descriptor de acceso "set", dentro de la propiedad, pero ´¿y el parámetro? Usaremos value dentro de set (abajo)

            Console.WriteLine($"El combustible es: {automovil1.Combustible}"); // Recordemos que tenemos que acceder a través de la propiedad y no el campo.
        }
                
    }
    //DECLARACIÓN DE UNA CLASE (fuera de la clase anterior, dentro del namespace):

    //[modificador de acceso] [class] [identificador]

    public class Automovil //Automóvil sería la clase, el plano a partir del cual nosotros podriamos crear muchos automoviles con los mismos datos y comportamientos
    {
        //Campos:
       
        private string color = "rojo", modelo, combustible; // Al cambiar los campos a "private", vemos que los identificadores se vuelven grises scuros y que al posicionarnos sobre ellos sale un candado. Además, los campos de color y combustible que habíamos usado en Main, nos marcan error, xq no son accesibles debido a su nivel de accesibilidad privado.
        private byte año, numPuertas;
        private int ccMotor;


        //PROPIEDADES:
        //[acceso][tipo][nombre]

        public string Color //Como las propiedades son métodos especializados, se declaran prácticamente igual, y con notación Pascal.
        {
            //Dentro vamos a tener al descriptor de acceso get, a set o a ambos:
                    

            //descriptor de acceso / accessor get

            get { return color; } //Como solo hay get, es de lectura nada más.
            // este bloque de código pertenece a get, no a la propiedad, y se suele escribir en una línea, aunque da igual. Aquí deberíamos devolver un tipo de valor, como haríamos con un "return".

            //MIEMBRO CON OTRA FORMA DE EXPRESIÓN:
            //miembro => expresión;

            //get => color;

            //descriptor de acceso / accessor set (o no)

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

        //Métodos:

        //(hemos borrado los métodos)


        // F12 --> Para que te dirija al origen de la variable, método, clase, etc, para ver de dónde viene
    }
}

