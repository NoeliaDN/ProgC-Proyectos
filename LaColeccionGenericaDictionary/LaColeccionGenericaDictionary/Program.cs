using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaColeccionGenericaDictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //LA COLECCION GENÉRICA "Dictionary":

            //Dictionary<TKey, TValue> nombre = new Dictionary<TKey, TValue>(constructor);

            Dictionary<string, int> empleados = new Dictionary<string, int>();

            //Añadiendo un Key-value pairs a la colección:

            empleados.Add("Hugo", 36);//NO SE PUEDE AGREGAR UN ELEMENTO CON LA MISMA "Key/clave"!!!
            empleados.Add("Erika", 20);

            foreach (KeyValuePair<string, int> elemento in empleados)//--> Para cada elemento de tipo KeyValuePair, con una key de tipo string y un value de tipo int (pues tiene que coincidir con la declaracion) que se encuentre dentro de la coleccion generica de "empleados", tendrá que hacer:

            {
                //Console.WriteLine(elemento);//Se muestran ambos pero en corchetes xq estamos imprimiendo los dos, el key y el value, pero podemos imprimirlos por separado, x ej:

                //Console.WriteLine(elemento.Key);
                //Console.WriteLine(elemento.Value);

                Console.WriteLine($"Key = {elemento.Key}, Value = {elemento.Value}");
            }


            //SINTAXIS DE la propiedad "item":

            //coleccion[Key] = value;

            empleados["Miguel"] = 45; // Con Add hubiéramos escrito: empleados.Add("Miguel", 45);


            //Después de agregar con elemento con "item":

            Console.WriteLine("\nDespués de agregar con elemento con \"item\": \n");

            foreach (KeyValuePair<string, int> elemento in empleados)
            {

                Console.WriteLine($"Key = {elemento.Key}, Value = {elemento.Value}");
            }

            //comprobando que "item" reemplaza la Key:

            Console.WriteLine("\nComprobando que \"item\" reemplaza la (Key): \n");

            empleados["Hugo"] = 19;// Como podemos ver, al usar Item en vez de Add, podemos volver a usar una Key ya existente, pero se sobreeescribe y se le asigna el nuevo valor

            foreach (KeyValuePair<string, int> elemento in empleados)
            {

                Console.WriteLine($"Key = {elemento.Key}, Value = {elemento.Value}");
            }

            //Usando el "get" de la propiedad "item" []:

            Console.WriteLine($"\n La edad de Erica es: {empleados["Erika"]} \n"); //Colocamos el key para obtener su valor

            //Y qué pasa si no existe la Key cuyo valor queremos devolver con "get"?:

            //Console.WriteLine($"\n La edad de Erica es: {empleados["Maria"]} \n");//No existe, x lo que se produce una excepción


            //Eliminando elementos de la colección con Remove():

            Console.WriteLine("\nDespués de eliminar un elemento: \n");

            empleados.Remove("Erika");

            foreach (KeyValuePair<string, int> elemento in empleados)
            {

                Console.WriteLine($"Key = {elemento.Key}, Value = {elemento.Value}");//Vemos que ya no nos muestra a Erika
            }

            Console.WriteLine();


            //Buscando si X Key/clave se se encuentra en la colección:

            if (empleados.ContainsKey("Erika"))
            {
                Console.WriteLine("La Key se encuentra en la colección.");
            }
            else
            {
                Console.WriteLine("La Key NO se encuentra en la colección.");

            }

            //Buscando si X Value/valor se se encuentra en la colección:

            if (empleados.ContainsValue(45))
            {
                Console.WriteLine("Existe al menos una persona con esa edad.");
            }
            else
            {
                Console.WriteLine("NO se encuentra nadie con esa edad en la colección.");

            }
        }
    }
}
