using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTupla
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // EL TIPO DE DATO TUPLA:

            // Imaginemos que queremos almacenar todos los datos de una persona.

            // Podemos declarar las variables que conocemos, pero si metemos las de otra persona, no sabremos cuáles pertenecerán a cada uno. 

            string nombre = "Luis";
            byte edad = 50;
            long telefono = 655443322;
            int dirPostal = 121122;

            //string nombre2 = "Pedro";
            //... 

            //Así, debemos convertir todas estas variables en una solaque las contenga a todas. Vamos a llamar a nuestra tupla "persona1".

            //SINTAXIS: (tipo) Identificador de nombre = (valor);

            // (string) persona1 = ("Luis"); 
            // Si solo introducimos un tipode dato nos dará error. Para hacer unatupla, tenemos que tener más de un dato, separándolos con comas.

           (string, byte, long, int) persona1 = ("Luis", 50, 655443322, 001122);

            // Con esto hemos creado nuestra "variable de tipo tupla", una variable que contiene varios tipo de datos distintos, pero relacionados entre sí, ya que pertenecen a la persona 1. Otra opción es usar "var" en vez de escribir todos los tipos y dejar que el compilador decida, x ej:

            //var persona1 = ("Luis", 50, 655443322, 001122);

            // las VARIABLES DE TIPO TUPLA contiene 2 o más campos en su interior, x ej: Luis, 50, 655443322, 001122, son campos, no se consideran variables. De hecho, si declaramos unas variables con el mismo nombre no dará lugar a error.

            // ahora, ¿cómo mostramos los campos de esta variable tupla en la consola?

           
            Console.WriteLine(persona1); // Mostrará los campos en paréntesis separados por comas.

            // Pero si queremos mostrar solo alguno de esos datos tenemos 3 opciones:

            //1.

            // Los campos que tiene la TUPLA se van a identificar como "items".

            //MOSTRANDO ITEMS EN LA CONSOLA:

            Console.WriteLine($"{nombre}, {edad}, {telefono}");


            //2.

            Console.WriteLine(persona1.Item1); // El item 1 corresponde al nombre, Luis

            //3.1.

            // Cambiamos la sintaxis de la TUPLA añadiendo el identificador de la variable en los valores de la tupla antes y con ":":

            var persona2 = (nombre: "Pepe", edad: 50, telefono: 655443322, dirPostal: 001122); // Si no especifico "var", da error, xq esta opción solo para para asignaciones de tipo implícito.

            Console.WriteLine(persona2.nombre);

            // 3.2. Si incluimos los tipos en vez de "var",podemos mostrar los valores añadiendo los identificadores de nombre a los tipos:

            (string nombre, byte edad, long telefono, int dirPostal) persona2 = ("Pepe", 50, 655443322, 001122); 

            Console.WriteLine(persona2.telefono);








        }
    }
}
