namespace EjercicioA
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Ejercicio A [1 pto]: Un programa que pregunte un nombre de fichero y
             * muestre en pantalla el contenido de ese fichero, haciendo una pausa 
             * después de cada 25 líneas, para que dé tiempo a leerlo. Cuando el 
             * usuario pulse la tecla Intro, se mostrarán las siguientes 25 líneas,
             * y así hasta que termine el fichero.*/

            //Se pide el nombre del fichero
            Console.WriteLine("Introduce el nombre del fichero: ");
            string nombreFichero = Console.ReadLine();

            //Uso la clase StremReader para leer el fichero
            StreamReader fichero;

            string? linea;
            int cont = 0;

            try
            {
                //Se abre el fichero para su lectura
                fichero = File.OpenText(nombreFichero);

                do
                {
                    // Lee una línea del fichero
                    linea = fichero.ReadLine();

                    if (linea != null)
                    {
                        // Muestra la línea actual en la consola
                        Console.WriteLine(linea);
                        cont++;
                    }

                    //Se hace una pausa después de mostrar 25 líneas
                    if (cont % 25 == 0)
                    {
                        // Se espera a que el usuario presione la tecla Intro
                        Console.ReadLine();
                    }
                } while (linea != null);

                // Cierra el fichero después de leer todas las líneas
                fichero.Close();
            }
            catch (FileNotFoundException)
            {
                // Captura la excepción si el fichero no se encuentra
                Console.WriteLine("El fichero no se encontró.");
            }
            catch (Exception ex)
            {
                // Captura cualquier otra excepción y muestra un mensaje de error
                Console.WriteLine($"Error: {ex.Message}");
            }

        }
    }
}