using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Socio
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public DateTime FechaNac { get; set; }
        public Deporte Deporte1 { get; set; }
        public Deporte Deporte2 { get; set; }

        public Socio() { }

        public bool EsMayor()
        {
            DateTime ahora = DateTime.Now;
            DateTime fechaNacPlus18 = FechaNac.AddYears(18);

            return ahora > fechaNacPlus18;

           // return ((DateTime.Now - FechaNac) >  18) ;
        }
    }
}
