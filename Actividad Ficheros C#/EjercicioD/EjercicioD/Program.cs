using System.Text;

namespace EjercicioD
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Ejercicio D [5 ptos]: Un programa que muestre el nombre del autor de un fichero de música en
            formato MP3 (tendrás que localizar en Internet la información sobre dicho formato y sobre la
            cabecera ID3 V1, que se encuentra -si está presente- en los últimos 128 bytes del fichero) Guarda
            el Título y el autor en un fichero con el mismo nombre y extensión .txt. */

            // Solicito introducir el nombre del archivo MP3
            Console.Write("Ingrese el nombre del archivo MP3: ");
            string nombreMP3 = Console.ReadLine();

            // Creo constantes para el manejo de la cabecera ID3 V1
            int tamCabecera = 128;
            int tamTitulo = 30;
            int tamArtista = 20;

            // Creo variables para almacenar el título y el artista
            string titulo = "";
            string artista = "";

            try
            {
                // Abro el archivo MP3 y busca la información en la cabecera ID3 V1
                using (FileStream ficheroMP3 = new FileStream(nombreMP3, FileMode.Open, FileAccess.Read))
                {
                    // Posicionarse en los últimos 128 bytes del archivo MP3
                    ficheroMP3.Seek(-tamCabecera, SeekOrigin.End);
                   
                    // Utilizar BinaryReader para leer datos binarios del archivo
                    using (BinaryReader br = new BinaryReader(ficheroMP3))
                    {
                        // Verifico si la cabecera ID3 V1 está presente
                        string id3Tag = Encoding.ASCII.GetString(br.ReadBytes(3));
                        if (id3Tag.Equals("TAG", StringComparison.OrdinalIgnoreCase))
                        {
                            //Se lee el título y el artista
                            titulo = Encoding.ASCII.GetString(br.ReadBytes(tamTitulo)).Trim();
                            artista = Encoding.ASCII.GetString(br.ReadBytes(tamArtista)).Trim();
                        }
                    }
                }

                // Creo la ruta del archivo de salida con la extensión .txt
                string ficheroSalida= Path.ChangeExtension(nombreMP3, ".txt");

                // Se guarda la información en un archivo de texto
                using (StreamWriter fichero = new StreamWriter(ficheroSalida))
                {
                    fichero.WriteLine("Título: " + titulo);
                    fichero.WriteLine("Artista: " + artista);
                    Console.WriteLine("La información se ha guardado en: " + ficheroSalida);
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
