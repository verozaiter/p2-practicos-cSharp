using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Chofer
    {
        public int Cod { get; set; }
        public string NombreCompleto { get; set; }
        public DateTime FechaIngreso { get; set; }

        public Chofer(int cod, string nombreCompleto, DateTime fechaIngreso)
        {
            Cod = cod;
            NombreCompleto = nombreCompleto;
            FechaIngreso = fechaIngreso;
        }
    }
}
