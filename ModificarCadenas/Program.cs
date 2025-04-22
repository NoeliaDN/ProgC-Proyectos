namespace ModificarCadenas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string textoOriginal = "viacheslav Konstantínovich von Pleve (en ruso: Вячесла́в Константи́нович фон Пле́ве, romanización Vjačeslav Konstantínovič fon Pleve), a veces también Plehve o von Plehwe (Meschovsk, 1846-San Petersburgo, 1904), fue un funcionario, político y ministro ruso.";

            //Reemplazamos el nombre propio sin Mayúsc con el de Mayúsc. para corregir cada aparición que pueda haber en el texto:

            string textoRemplazo = textoOriginal.Replace("viacheslav", "Viacheslav");
            Console.WriteLine(textoOriginal);
            Console.WriteLine();
            Console.WriteLine(textoRemplazo);

            //Practicamos con el método Trim():

            string texto_Original = "----Viacheslav Konstantínovich von Pleve (en ruso: Вячесла́в Константи́нович фон Пле́ве, romanización Vjačeslav Konstantínovič fon Pleve), a veces también Plehve o von Plehwe (Meschovsk, 1846-San Petersburgo, 1904), fue un funcionario, político y ministro ruso.----";

            //Queremos eliminar los guiones con Trim(char):

            string textoRemplazo2 = texto_Original.Trim('-');

            Console.WriteLine(texto_Original);
            Console.WriteLine();
            Console.WriteLine(textoRemplazo2);

            //Queremos eliminar los guiones con Trim()--> sin parámetros (para ello, eliminamos los guiones y dejamos espacios en blanco al ppio y al final):

            string textoRemplazo3 = texto_Original.Trim();

            Console.WriteLine(texto_Original);
            Console.WriteLine();
            Console.WriteLine(textoRemplazo3);

            //Tambn tenemos TrimStart() y TrimEnd().


            //Practicamos con el método Remove(startindex, count):

            string texto_Original2 = "Viacheslav Konstantínovich von Pleve (en ruso: Вячесла́в Константи́нович фон Пле́ве, romanización Vjačeslav Konstantínovič fon Pleve), a veces también Plehve o von Plehwe (Meschovsk, 1846-San Petersburgo, 1904), fue un funcionario, político y ministro ruso.";

            //Si queremos eliminar "Pleve", x ej:

            string textoRemplazo4 = texto_Original.Remove(35, 6); //desde el carácter nº 35, incluido, eliminamos 6 caracteres
            Console.WriteLine(texto_Original);
            Console.WriteLine();
            Console.WriteLine(textoRemplazo4);

            //Si usamos la sobrecarga con un parámetro Remove(int32), int32 equivaldría a la posición del caracter a partir del cual eliminará todo lo que siga hasta el final, incluyendo el caracter:
            string textoRemplazo5 = texto_Original.Remove(35); 
            Console.WriteLine(texto_Original);
            Console.WriteLine();
            Console.WriteLine(textoRemplazo5);


        }
    }
}
