using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Cuenta
    {
        public int Numero { get; set; }

        public TipoMoneda Moneda { get; set; }

        public double Saldo { get; set; }

        public static double Cambio { get { return 40; } }

        public int CantidadDepositos { get; set; }

        public Cuenta()
        {
            CantidadDepositos = 0;
        }
        
        
        public void Deposito(double monto, TipoMoneda tipoMoneda)
        {
            
            if (this.Moneda == TipoMoneda.DOLARES &&  tipoMoneda == TipoMoneda.DOLARES)
            {
                this.Saldo += monto;
                if (CantidadDepositos > 3)  this.Saldo -= 100 / Cambio; 
            }

            if (this.Moneda == TipoMoneda.PESOS && tipoMoneda == TipoMoneda.PESOS)
            {
                this.Saldo += monto;
                if (CantidadDepositos > 3) this.Saldo -= 100;
            }

            if (this.Moneda == TipoMoneda.PESOS && tipoMoneda == TipoMoneda.DOLARES)
            {
                this.Saldo += monto * Cambio;
                if (CantidadDepositos > 3) this.Saldo -= 100;
            }

            if (this.Moneda == TipoMoneda.DOLARES && tipoMoneda == TipoMoneda.PESOS)
                {
                this.Saldo += monto / Cambio;
                if (CantidadDepositos > 3) this.Saldo -= 100 / Cambio;
            }

            this.CantidadDepositos++;

        }

        public void Retiro(double monto, TipoMoneda tipoMoneda)
        {
            double montoARetirar = 0;
            if (this.Moneda == TipoMoneda.PESOS && tipoMoneda == TipoMoneda.DOLARES)
            {
                montoARetirar = monto * Cambio;
            }

            if (this.Moneda == TipoMoneda.DOLARES && tipoMoneda == TipoMoneda.PESOS)
            {
                montoARetirar = monto / Cambio;
            }
            if (this.Saldo < montoARetirar)
            {
                throw new Exception("No tienes saldo suficiente para retirar ese monto.");
            }

            this.Saldo -= montoARetirar;
        }

        public override string ToString()
        {
            return $"        Cuenta número {Numero}\n        Saldo: {Saldo}\n        TipoMoneda: {Moneda}\n        Cantidad de Depositos: {CantidadDepositos}";
        }
    }
}
