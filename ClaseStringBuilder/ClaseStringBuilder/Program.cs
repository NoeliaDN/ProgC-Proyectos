using System.Text;

namespace ClaseStringBuilder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string numeros = "";

            //for (int i = 1; i <= 100; i++) //crearemos un total de 100 objetos, lo cual supone una pérdida de rendimiento muy notable
            //{
            //    numeros += 1 + ",";
            //}
            //Console.WriteLine(numeros);

            StringBuilder numeros = new StringBuilder();
           //numeros.Append(15.6);
           for(int i = 1; i <=100; i++)
            {
                numeros.Append(i); //En cada vuelta, al objeto "numeros" de tipo StringBuilder, se le van a estar agregando objetos de tipo int32 desde el 1 hasta el 100, xq int es una variable local de tipo int
                numeros.Append(", ");//Así, arriba le añadiremos un número y ahora una coma.


            }
            //string cadenaNumeros = numeros; //Vemos que no podemos convertir el número StringBuilder a String implícitamente. Lo intentamos explícitamente  con casting: string cadenaNumeros = (string)numeros; y tampoco, dado que este tipo de conversión es sobretodo para numéricos.
            //Tenemos que usar el método ToString:
            string cadenaNumeros = numeros.ToString(); //Y ya no nos da error

            //Al convertirlo en String, ya podremos usar todos los métodos de la clase String. Probemos:

            Console.WriteLine(cadenaNumeros);//Vemos que contiene del 1 hasta el 100 con las comas, tal y como hacía el primer "for", pero mejorando el rendimiento, dado que no creamos un objeto 100 veces, si no que se creó un objeto y se fue modificando.


        }
    }
}
