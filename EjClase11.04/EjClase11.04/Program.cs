using Dominio;

namespace EjClase11._04
{
    public class Program
    {
        static void Main(string[] args)
        {
            Sistema sistema = Sistema.ObtenerInstancia;
            Libro nuevoLibro = new Libro("Vero Z", "123FF");
            Libro otroLibro = new Libro("Hola bb", "123FF");
            

            try
            {
                sistema.AltaLibro(nuevoLibro);
            } 
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            try
            {
                sistema.AltaLibro(otroLibro);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }
    }
}