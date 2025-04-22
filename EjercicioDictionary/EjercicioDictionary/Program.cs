using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioDictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Variables

            int opcion;
            string nombre; //nombre del contacto
            long numero; //nº del contacto

            //declaración e instancia de la colección:

            Dictionary<string, long> contactos = new Dictionary<string, long>();

            do
            {
                Console.Clear();

                Console.WriteLine("Escoge una opción: ");

                Console.WriteLine("\n1. Agregar contacto. ");
                Console.WriteLine("2. Buscar contacto. ");
                Console.WriteLine("3. Eliminar contacto. ");
                Console.WriteLine("4. Mostrar contactos.\n ");

                opcion = Convert.ToInt32(Console.ReadLine());

                switch (opcion)
                {
                    case 1:

                        Console.Write("Escriba el nombre: ");
                        nombre = Console.ReadLine();

                        Console.Write("Escriba el número de teléfono: ");
                        numero = Convert.ToInt64(Console.ReadLine());

                        contactos.Add(nombre, numero);

                        Console.WriteLine($"\n¡{nombre} ha sido agregado con éxito! :)");

                        Console.WriteLine("\nPresiona cualquier tecla para regresar al menú. ");

                        Console.ReadKey();

                        break;

                    case 2:

                        Console.Write("Escriba el nombre del contacto que desea buscar: ");
                        nombre = Console.ReadLine();
                                                
                        if (contactos.ContainsKey(nombre))
                        {
                            Console.WriteLine("¡Contacto encontrado!");
                            Console.WriteLine($"{nombre}: {contactos[nombre]} ");

                            Console.WriteLine("\nPresiona cualquier tecla para regresar al menú. ");

                            Console.ReadKey();
                        }
                        else
                        {
                            Console.WriteLine("¡El contacto no existe!");

                            Console.WriteLine("\nPresiona cualquier tecla para regresar al menú. ");

                            Console.ReadKey();
                        }
                        break;

                    case 3:
                        Console.Write("Escriba el nombre del contacto que desea eliminar: ");
                        nombre = Console.ReadLine();

                        

                        if (contactos.ContainsKey(nombre))
                        {
                            contactos.Remove(nombre);

                            Console.WriteLine($"{nombre} ha sido eliminado correctamente de tu lista de contactos. ");

                            Console.WriteLine("\nPresiona cualquier tecla para regresar al menú. ");

                            Console.ReadKey();
                        }
                        else
                        {
                            Console.WriteLine("¡El contacto no existe!");

                            Console.WriteLine("\nPresiona cualquier tecla para regresar al menú. ");

                            Console.ReadKey();
                        }

                        break;

                    case 4:
                        Console.WriteLine("\nContactos en tu agenda: ");

                        foreach(KeyValuePair<string, long> elemento in contactos)
                        {
                            Console.WriteLine($"{elemento.Key}: {elemento.Value}");

                        }

                        Console.WriteLine("\nPresiona cualquier tecla para regresar al menú. ");

                        Console.ReadKey();

                        break;
                }

            } while (opcion >= 1 || opcion <= 4);

        }
    }
}
