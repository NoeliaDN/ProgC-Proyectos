using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Para que se vea el símbolo del "€":

            Console.OutputEncoding = System.Text.Encoding.UTF8;

            //Variables locales:

            string nombreArg, apellidosArg, direccionArg, DNIArg;
            double saldoArg;
            byte opcion;

            //Solicitar los datos:

            Console.WriteLine("¡Bienvenido a TUSACA, el banco preferido de los andorranos!\n");

            Console.WriteLine("Antes de empezar, por favor, introduzca los siguientes datos: \n");

            Console.Write("Nombre: ");
            nombreArg = Console.ReadLine();

            Console.Write("Apellidos:");
            apellidosArg = Console.ReadLine();

            Console.Write("DNI: ");
            DNIArg = Console.ReadLine();

            Console.Write("Dirección: ");
            direccionArg = Console.ReadLine();

            Console.Write("Por último, introduzca el saldo inicial que desee introducir en su cuenta bancaria: ");
            saldoArg = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("\n");

            Console.WriteLine("¡Muchas gracias! Ya puede realizar las siguientes acciones marcando el número correspondiente: \n");

            //Instanciamos la clase y mandamos los argumentos al constructor:

            CuentaBancaria cuentaBancaria1 = new CuentaBancaria(nombreArg, apellidosArg, saldoArg, direccionArg, DNIArg);

            do
            {
                Console.WriteLine("1. Depósito.");
                Console.WriteLine("2. Retirada.");
                Console.WriteLine("3. Consultar saldo.");
                Console.WriteLine("4. Mostrar información de la cuenta.");
                Console.WriteLine("5. Salir.\n");

                opcion = Convert.ToByte(Console.ReadLine());

                
                switch (opcion)
                {
                    case 1:

                        Console.WriteLine("\n");
                        saldoArg = cuentaBancaria1.Deposito();
                                                
                        break;
                    case 2:
                        Console.WriteLine("\n");
                        saldoArg = cuentaBancaria1.Retiro();

                        
                        break;

                    case 3:
                        Console.WriteLine("\n");
                        cuentaBancaria1.ConsultaSaldo();

                        break;
                                                
                    case 4:

                        Console.WriteLine("\n");
                        
                        Console.WriteLine(cuentaBancaria1.ToString());

                        break;

                    case 5:

                        break;
                }
                    
            }
            while (opcion != 5);


           

        }
    }

    class CuentaBancaria
    {
        //Campos:

        private string nombre, apellidos, direccion, DNI;
        private double saldo;

        //MÉTODOS:

        //Constructor: 
  
        public CuentaBancaria(string nombrePa, string apellidosPa, double saldoPa, string direccionPa, string DNIPa)
        {
            nombre = nombrePa;
            apellidos = apellidosPa;
            saldo = saldoPa;
            direccion = direccionPa;
            DNI = DNIPa;
        }

        //Otros métodos:

        public double Deposito()
        {
            double montoPa;
            Console.Write("Qué cantidad desea ingresar?: ");
            montoPa = Convert.ToDouble(Console.ReadLine());
            saldo += montoPa;

            Console.WriteLine($"Operación realizada con éxito. Ahora dispone de un saldo de {saldo}€. \n");

            return saldo;

        }

        public double Retiro()


        {
            double montoPa;

            Console.Write("Qué cantidad desea retirar?: ");
            montoPa = Convert.ToDouble(Console.ReadLine());



            if (montoPa >= saldo)
            {
                Console.WriteLine("Lo sentimos. No dispone del saldo suficiente para retirar la cantidad especificada :( \n");
            }
            else
            {
                saldo -= montoPa;
                Console.WriteLine($"Operación realizada con éxito. Ahora dispone de un saldo de {saldo}€. \n");
            }

            return saldo;

        }

        public void ConsultaSaldo()
        {
            Console.WriteLine($"Actualmente dispone de un saldo de {saldo}€. \n");

        }

        public override string ToString() //Invalidar el método para mostrar un mensaje concreto según nuestro fomato con los datos, de cara  a mostrar la info de la cuenta, tal y como debemos hacer en la opción 4.
        {
            string mensaje;

            mensaje = "Titular: " + nombre + "\nApellidos: " + apellidos + "\nDirección: " + direccion + "DNI: " + DNI + "\nSaldo en su cuenta: " + saldo + "\n";

            return mensaje;

        }
    }
}
