using Dominio;

namespace Dominio
{
    public class Sistema
    {
        private List<Libro> Libros { get; set; }

        private static Sistema instancia;

        public static Sistema ObtenerInstancia 
        {
            get
            {
                if (instancia == null) instancia = new Sistema(); 
                return instancia;
            }
        }

        private Sistema() 
        { 
            Libros = new List<Libro>();
        }

        public void AltaLibro(Libro libro)
        {
            Chequeo(libro);
            Libros.Add(libro);
        }

        private void Chequeo(Libro libro)
        {
            libro.Validar();
            if (Libros.Contains(libro)) throw new Exception("Este libro ya existe.");
        }


       
    }
}