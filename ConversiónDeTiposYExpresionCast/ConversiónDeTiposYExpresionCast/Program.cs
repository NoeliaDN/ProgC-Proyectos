using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversiónDeTiposYExpresionCast
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //object objeto;
            //objeto = = "Antonio";
            //objeto = 34.56;

            //object numero1 = 5;
            //object numero2 = 20;
            //object resultado;

            //No se puede realizar operaciones aritméticas con el tipo "object", aunque se le pueda asignar cualquier tipo. Por eso, veremos cómo convertirlo.

            // Los tipos diferentes tampoco se puede operar entre sí, x ej, un double a un int:

            int numero = 10;

            //Tambn podemos convertir un método a otro tipo, si queremos recibir el int y convertirlo a float como parámetro:

            //static void Prueba(float numeroPa)
            //{

            //}

            //CONVERSIÓN IMPLÍCITA:

            //No requieren sintaxis extra.

            //Por ej, la conversión de un tipo entero pequeño a uno grande:

            //byte numPequeño = 125;
            //int numGrande = numPequeño;

            //Es implícita xq int ya incluye el intervalo de byte dentro de su propio intervalo, x lo que solo le estamos asignando el valor de la variable byte a la variable int, que perfectamente puede almacenar "125", lo cual no podríamos hacer al revés. Para ello, ya necesitaríamos las conversiones explícitas, para las que necesitamos la "expresión cast".

            //CONVERSIÓN EXPLÍCITA:

            //Necesitamos la expresión "cast", cuyo formato es: (T) E, es decir: (tipo al que queremos convertir) expresión que queremos convertir. Sin embargo, hay conversiones que no son válidas (link de recursos 182), x ej string no se puede convertir a tipo numérico. Veremos que int a byte sí es posible con cast (dado que es explícita):

            //int numGrande = 500;
            //byte numPequeño = (byte) numGrande;
            ////                  (T)   E

            //Esto es "hacer casting" / "usar un casting".

            //CONVERSIÓN CON TIPOS OBJECT:
            
            object numero1 = 5;
            object numero2 = 20;
            object resultado;

            //Si recordamos el ejercicio, debíamos hacer una operación con estos valores, pero al ser "object", no podíamos, teníamos que hacer una conversión:

            //BOXING:
            //- tipo de valor --> tipo object
            //- es implícita( la podemos hacer explícita, pero nunca va a ser necesario)
            //La conversión boxing copia el valor de "a" dentro del objeto "obj":

            int a = 50;
            object obj = a;

            //UNBOXING:

            //- tipo object --> tipo de valor
            //- DEBE ser explícita (expresión "cast")
            //Convierte un "object" a un tipo de valor.

            //resultado = numero1 + 10; //Como veíamos, al ser object, no podíamos operar. por ello, haremos unboxing para convertir este "object" en un tipo de valor, x ej : int:

            resultado = (int)numero1 + 10;
            ////                  (T) E
            Console.WriteLine(resultado);//Para comprobar que el "unboxing" haya tenido éxito.






        }
    }
}
