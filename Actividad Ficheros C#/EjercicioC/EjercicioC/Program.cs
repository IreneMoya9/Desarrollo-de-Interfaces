namespace EjercicioC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Ejercicio C [2 ptos]: Abre un fichero (cuyo nombre introducirá el usuario) y 
             * muestra si se trata de un fichero bmp, gif o de otro tipo 
             * (mostrará por consola “NombreFichero: Tipo” 
             * [En un archivo BMP, los dos primeros bytes del archivo corresponden a una letra "B" y una letra "M",
             * respectivamente. En un archivo GIF, los tres primeros bytes son las letras G, I, F]*/

            // Solicito introducir el nombre del fichero de entrada
            Console.WriteLine("Introduce el nombre del fichero: ");
            string nombreFichero = Console.ReadLine();

            try
            {
                // Abro el fichero en modo de lectura
                using (BinaryReader fichero = new BinaryReader(File.Open(nombreFichero, FileMode.Open, FileAccess.Read)))
                {
                    // Leo los primeros tres bytes del fichero y lo paso a caracter
                    char byte1 = Convert.ToChar(fichero.ReadByte());
                    char byte2 = Convert.ToChar(fichero.ReadByte());
                    char byte3 = Convert.ToChar(fichero.ReadByte());

                    // Comparo los bytes leídos con las letras BMP y GIF
                    if (byte1 == 'B' && byte2 == 'M' && byte3 == 'P')
                        Console.WriteLine("El fichero" + Path.GetFileNameWithoutExtension(nombreFichero) + "es de tipo BMP");
                    else if (byte1 == 'G' && byte2 == 'I' && byte3 == 'F')
                        Console.WriteLine("El fichero " + Path.GetFileNameWithoutExtension(nombreFichero) + " es de tipo GIF");
                    else
                        Console.WriteLine("El fichero " + Path.GetFileNameWithoutExtension(nombreFichero)+" es de otro tipo");
                }
            }
            catch (Exception ex)
            {
                // Captura y muestra cualquier excepción que pueda ocurrir
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }
}
