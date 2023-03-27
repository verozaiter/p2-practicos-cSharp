using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Viaje
    {
        public DateTime Fecha { get; set; }
        public string CiudadOrigen { get; set; }
        public string CiudadDestino { get; set; }
        public Chofer Chofer { get; set; }
        public Remise Remise { get; set; }

        public Viaje() { }
    }
}
