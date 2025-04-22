using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SobrecargarMetodo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Variable para recibir desde Concatenar():

            string nombreYApellido;

            //Para usar el método, instanciamos la clase:

            Nombres nombres = new Nombres();

            nombreYApellido = nombres.Concatenar("Leticia", "Guzmán", "Valdés");// Usaremos la referencia del objeto creado para invocar al método. Le damos los argumentos directamente, no se los pedimos al usuario para no hacer más tedioso el ejemplo.
                                                                                //
             //Al sobrecargar el método, si nos posicionamos con el ratón sobre "Concatenar()", veremos que dice "sobrecarga + 1" y que está usando la segunda versión del método. Si borramos el tercer apellido, nos indica la primera versión del método.

            //Mostrando la scadenas ya concatenadas:

            Console.WriteLine(nombreYApellido);

        }
    }

    class Nombres
    {
        //Método

        public string Concatenar(string nombrePa, string apellidoPa) // Método string que recibe 2 parámetros
        {
            //Variable local que va a concatenar a los 2 parámetros ue recibimos:

            string nombreApellido;

            nombreApellido = nombrePa + " " + apellidoPa; //asignamos la concatenación de nombre y apellido a nombreApellido y la devolvemos con "return"
            return nombreApellido;
        }

        //Sobrecarga del metodo Concatenar para incluir un segundo apellido, es decir, que admita un tercer parámetro:

        public string Concatenar(string nombrePa, string apellidoPa, string apellido2Pa)
        {
            //Variable local que va a concatenar a los 3 parámetros que recibimos:

            string nombreApellido;

            nombreApellido = nombrePa + " " + apellidoPa + " " + apellido2Pa; //asignamos la concatenación de nombre y los 2 apellidos a nombreApellido y la devolvemos con "return"

            return nombreApellido;

        }
    }
}
