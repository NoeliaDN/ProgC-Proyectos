using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace EjemploSinGenericos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Variables locales:
            Alumno valorElemento; //CAMBIAMOS TIPO string A "Alumno", ya que, al crear un  tipo de referencia Alumno, podemos crear variables de ese tipo

            //Primero, instanciamos la clase:

            GuardaObjetos objetos1 = new GuardaObjetos(3); //Mandamos el argumento "3", que se envía al constructor y se inicializa la matriz con 3 elementos.

            //Agregar objetos tipo string:

            //objetos1.AgregarElementos("Luis");
            //objetos1.AgregarElementos("José");
            //objetos1.AgregarElementos("Juan");

            //COMENTAMOS LOS OBJETOS TIPO STRING PARA PRACTICAR CON LA CLASE ALUMNO

            //Instanciamos la clase Alumno 3 veces para agregar 3 calificaciones 

            Alumno alumno1 = new Alumno(8.5);
            Alumno alumno2 = new Alumno(10);
            Alumno alumno3 = new Alumno(6.8);

            //y asignarlos a la matriz de GuardaObjetos, que, al ser object, admite tipo "alumno" tambn:

            objetos1.AgregarElementos(alumno1);
            objetos1.AgregarElementos(alumno2);
            objetos1.AgregarElementos(alumno3);

            //Sin embargo, nos dice solo al ejecutarlo que no se puede convertir "tipo alumno" a tipo String", x lo que modificamos la variable string local a Alumno (arriba y convertimos a "Alumno" (abajo, en la conversión con cast), no a string


            //Obtener elemento:

            //valorElemento = objetos1.ObtenerElemento(2); //Queremos que se devuelva el índice "2", pero dice que no puede convertir object a string
            //Console.WriteLine(valorElemento);//Pero no se puede convertir el tipo "object" en "string". La matriz es de tipo object, x lo que sus elementos tambn lo son. Necesitamos convertirlo haciendo casting antes, x ej: valorElemento = (string)objetos1.ObtenerElemento(0);

            valorElemento = (Alumno)objetos1.ObtenerElemento(0);
            Console.WriteLine(valorElemento);//Pero no se puede convertir el tipo "object" en "string". La matriz es de tipo object, x lo que sus elementos tambn lo son. Necesitamos convertirlo haciendo casting antes.
            Console.WriteLine(valorElemento.Calificacion); // Al agregar las calificaciones como elementos a la matriz de la clase GUardaObjetos y asignarlos a valorElemento, hemos hecho que tenga la misma informacion y que pueda acceder a los mismos miembros de la clase, como a la propiedad "Calificacion"
        }
    }


    class GuardaObjetos
    {
        //Campos

        private int i = 0;
        private object[] matrizElementos; //La matriz de elementos de tipo object, para que admita cualquier tipo

        //Constructor(para inicializar campos):

        public GuardaObjetos(int elementosPa)
        {
            //Inicializamos a la matriz:

            matrizElementos = new object[elementosPa]; // Se va a inicializar con el número de elementos que le digamos

        }
        //Métodos:

        //1º método para agregar elementos a la matriz:

        public void AgregarElementos(object elementoPa)
        {
            matrizElementos[i] = elementoPa;
            i++; // Para que cada vez que llamemos al método agreguemos + 1 y se asigne a "i"
        }

        //2º método para obtener y mostrar los elementos según índice:

        public object ObtenerElemento(int elementoPa)
        {
            return matrizElementos[elementoPa];//Para mostrar los elementosde los índices 0, 1, etc
        }

    }
    class Alumno//Será un TIPO DE REFERENCIA creado por nosotros; se encargará de almacenar la calificación de un alumno y de devolverla al exterior. Queremos que nuestra matriz, en vez de guardar tipos string, guarde tipos "Alumno".
    {
        //Campos
        double calificacion;

        //Constructor:

        public Alumno(double calificacionPa)//Para que en el momento de la instancia reciba la calificación, que le será asignada al campo "calificacion"
        {
            calificacion = calificacionPa;
        }

        //Propiedad solo con el descriptor de acceso "get", q se encargará de devolver al campo "calificacion":

        public double Calificacion// "public" xq lo necesitaremos usar desde el exterior, "double" xq devuelve valor "double" y con mayúsculas xq es una propiedad del campo "calificacion", cn minuscula
        {
            get => calificacion;

        }


    }
}
