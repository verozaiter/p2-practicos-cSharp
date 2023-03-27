using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Espectaculo
    {
        public DateTime Fecha { get; set; }
        public string Nombre { get; set; }
        public string Descrip { get; set; }
        public string Responsable { get; set; }
        public Banda Banda { get; set; }

        public Espectaculo()
        {
        }

        public Espectaculo(DateTime fecha, string nombre, string descrip, string responsable, Banda banda)
        {
            Fecha = fecha;
            Nombre = nombre;
            Descrip = descrip;
            Responsable = responsable;
            Banda = banda;
        }




    }

}
