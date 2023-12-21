namespace EjercicioB
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Ejercicio B [1 pto]: Haz un programa que duplique un fichero, copiando todo 
             * su contenido a un nuevo fichero, byte a byte. El nombre del fichero de salida 
             * se tomará del nombre del fichero de entrada, al que se añadirá ".out". */

            // Solicito introducir el nombre del fichero de entrada
            Console.WriteLine("Introduce el nombre del fichero:");
            string? nombreFichero = Console.ReadLine();

            try
            {
                 
                    // Abro el fichero de entrada en modo lectura
                    using (FileStream ficheroEntrada = new FileStream(nombreFichero, FileMode.Open, FileAccess.Read))
                    {
                        // Creo el fichero de salida con el mismo nombre pero añadiendo ".out" y lo abro en modo escritura
                        using (FileStream ficheroSalida = new FileStream(Path.GetFileNameWithoutExtension(nombreFichero) + ".out", FileMode.Create, FileAccess.Write))
                        {
                            int byteLeido;
                            // Se lee byte a byte del fichero de entrada y escribe en el fichero de salida
                            while ((byteLeido = ficheroEntrada.ReadByte()) != -1)
                            {
                                ficheroSalida.WriteByte((byte)byteLeido);
                            }
                        }
                    }
                
                Console.WriteLine("Fichero duplicado correctamente");
            }
            catch (Exception ex)
            {
                // Captura y muestra cualquier excepción que pueda ocurrir
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }
}
           

