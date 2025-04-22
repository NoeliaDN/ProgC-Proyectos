using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploConGenericos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Variables locales:
            string valorElemento; //CAMBIAMOS TIPO string A "Alumno", ya que, al crear un  tipo de referencia Alumno, podemos crear variables de ese tipo

            //Primero, instanciamos la clase:

            //GuardaObjetos<Alumno> objetos1 = new GuardaObjetos<Alumno>(3); //Ahora requerimos argumentos de tipo para que la clase no de error, por lo que añadimos los paréntesis angulares con los parámetros de tipo, que será "Alumno".


            //COMENTAMOS LOS OBJETOS TIPO STRING PARA PRACTICAR CON LA CLASE ALUMNO

            //Instanciamos la clase Alumno 3 veces para agregar 3 calificaciones 

            Alumno alumno1 = new Alumno(8.5);
            Alumno alumno2 = new Alumno(10);
            Alumno alumno3 = new Alumno(6.8);

            //y asignarlos a la matriz de GuardaObjetos, que, al ser object, admite tipo "alumno" tambn:

            //objetos1.AgregarElementos(alumno1);
            //objetos1.AgregarElementos(alumno2);
            //objetos1.AgregarElementos(alumno3);

            //si queremos trabajar con elementos de otro tipo, x ej "string", lo indicaremos en los parámetros de tipo <>:

            GuardaObjetos<string> objetos1 = new GuardaObjetos<string>(3);

            //Agregar objetos:

            objetos1.AgregarElementos("Luis");
            objetos1.AgregarElementos("Jose");
            objetos1.AgregarElementos("Juan");



            //Obtener elemento:

            valorElemento = objetos1.ObtenerElemento(1);
            Console.WriteLine(valorElemento);
        }
    }


    class GuardaObjetos<T> //Agregamos la "<T>" para los parámetros de tipo y sustituíamos todos los "object" que veamos por "T". Ahora la clase va a almacenar toda clase de tipos, tanto de valor, como de referencia
    {
        //Campos

        private int i = 0;
        private T[] matrizElementos; //La matriz de elementos de tipo object, para que admita cualquier tipo

        //Constructor(para inicializar campos):

        public GuardaObjetos(int elementosPa)
        {
            //Inicializamos a la matriz:

            matrizElementos = new T[elementosPa]; // Se va a inicializar con el número de elementos que le digamos

        }
        //Métodos:

        //1º método para agregar elementos a la matriz:

        public void AgregarElementos(T elementoPa)
        {
            matrizElementos[i] = elementoPa;
            i++; // Para que cada vez que llamemos al método agreguemos + 1 y se asigne a "i"
        }

        //2º método para obtener y mostrar los elementos según índice:

        public T ObtenerElemento(int elementoPa)
        {
            return matrizElementos[elementoPa];//Para mostrar los elementosde los índices 0, 1, etc, esta vez con un tipo "T"
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

