using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Dominio
{
    public class Libro
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public Categoria Categoria { get; set; }
        public Autor Autor { get; set; }
        public string ISBN { get; set; }

        public static int contador = 0;

        public Libro(string nombre, string iSBN)
        {
            Nombre = nombre;
            ISBN = iSBN;
            Id = contador;
            contador++;
        }

        public void Validar() {

            ValidarNombre();
            ValidarISBN();
        }

        private void ValidarNombre() 
        {
            if (Nombre == null || Nombre == "") throw new Exception(message: "Nombre no puede ser vacío.");
            if (Nombre.Length > 20) throw new Exception(message: "El nombre debe tener menos de 20 caracteres.");
        }

        private void ValidarISBN()
        {
            if (ISBN == null || ISBN == "") throw new Exception(message: "ISBN no puede ser vacío.");
        }


        public override bool Equals(object? obj)
        {
            Libro libroAComparar = (Libro) obj;
            return ISBN == libroAComparar.ISBN;
        }

    }
}
