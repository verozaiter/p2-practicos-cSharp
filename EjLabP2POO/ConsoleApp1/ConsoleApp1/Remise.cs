using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Remise
    {
        public string Matricula { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public int NumMotor { get; set; }

        public Remise(string matricula, string marca, string modelo, int numMotor)
        {
            Matricula = matricula;
            Marca = marca;
            Modelo = modelo;
            NumMotor = numMotor;
        }
    }

   
}
