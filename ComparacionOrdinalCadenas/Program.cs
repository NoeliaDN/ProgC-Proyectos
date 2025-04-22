// See https://aka.ms/new-console-template for more information


//COMPARACIÓN ORDINAL DE CADENAS:

//Equals(string, string):


using System.Collections.Concurrent;

Console.WriteLine("Ingresa tu correo: ");

string correo= Console.ReadLine();

Console.WriteLine("Ingresa tu correo nuevamente: ");
string correoConfirmar= Console.ReadLine();

//Le aisgnamos a una variable booleana lo que devuelva Equals:

bool conincideCorreo = Equals(correo, correoConfirmar);

if (conincideCorreo)//si esta es TRUE
{
    Console.WriteLine("Registrado con éxito. ");
}
else
{
    {
        Console.WriteLine("Error");

    }
}
//Distingue entre Mayúsc. y Minúsc.

//Tambn podemos hacerlo con operadores de igualdad (==) o desigualdad (!=):

if (correo == correoConfirmar)//si esta es TRUE
{
    Console.WriteLine("Registrado con éxito. ");
}
else
{
    {
        Console.WriteLine("Error");

    }
}//Tambn distingue entre Máyusc, Minúsc. y nulas, la única diferencia es que el método Equals tiene muchas sobrecargas que nos podrían ayudar a resolver un problema más complejo.

//Otra sobrecarga es Equals(string), con un solo argumento:

string numero = "98765";

//se lo mostramos al usuario para que lo memorice y le damos un tiempo antes de repetirlo a ver si se acuerda:
Console.WriteLine($"Memoriza el siguiente número: {numero} y presiona enter cuando estés listo. ");
Console.ReadKey();

Console.Clear();

Console.WriteLine("Ingresa el número, ¡probemos que tan buena memoria tienes!");
string numero2 = Console.ReadLine();

//COMPROBAMOS si es el mismo nº con un IF:

if (numero.Equals(numero2))//SI la instancia (numero) es igual a el string guardado (numero2), tienen el mismo valor, hacer lo siguiente:
{
    Console.WriteLine("¡Acertaste!");
}
else
{
    Console.WriteLine("Lo siento. Buena suerte la próxima vez.");
}

//Las comparaciones ordinales distinguen entre Mayúsculas y Minúsc., por lo que tenemos que usar otras sobrecargas del método Equals() para no distinguir entre ellas:

//Equals(String, StringComparison)

Console.WriteLine("Ingresa tu correo: ");

string correo1 = Console.ReadLine();

Console.WriteLine("Ingresa tu correo nuevamente: ");
string correo2 = Console.ReadLine();

bool mismoCorreo;

mismoCorreo = correo.Equals(correoConfirmar, StringComparison.OrdinalIgnoreCase);//le decimos que la cadena se comparará de una forma ordinal ignorando el uso de Mayúsc. y minúsc.

if (mismoCorreo)//si esta es TRUE
{
    Console.WriteLine("Registrado con éxito. ");
}
else
{
    {
        Console.WriteLine("Error");

    }
}

//Si probamos a escribir el primer correo con mayúsc. y el segundo con minúsc., las dará como iguales.


Console.WriteLine("Registro pra nuevo ingreso\n");

Console.WriteLine("Ingresa tu nombre completo: ");
string nombre = Console.ReadLine();

Console.WriteLine("Ingresa tu correo electrónico: ");
string email = Console.ReadLine();

Console.Clear(); //limpiamos la consola

//Nos interesa que el nombre siempre salga en mayúsculas, por lo que usamos el método ToUpper():

Console.WriteLine("Verifica tu informaciçon: \n");

Console.WriteLine($"Nombre: {nombre.ToUpper()}");

//Para el correo, queremos que siempre salga en minúsculas, por lo que usamos el método ToLower():

Console.WriteLine($"Correo: {email.ToLower()}");

