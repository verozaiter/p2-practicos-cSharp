using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Banda
    {
        public int Cod { get; set; }
        public string Nombre { get; set; }
        public string EstiloMus { get; set; }



        public Banda(){}

        public Banda(int cod, string nombre, string estiloMus)
        {
            Cod = cod;
            Nombre = nombre;
            EstiloMus = estiloMus;
        }

        public bool HaEstadoEn(Espectaculo espectaculo)
        {
            return (this.Cod == espectaculo.Banda.Cod);
        }
    }

   


}
