using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class BancoSistema
    {

        private static BancoSistema Instancia;

        private List<Cliente> clientes;

        public static BancoSistema ObtenerInstancia
        {
            get
            {
                if (Instancia == null) Instancia = new BancoSistema();
                return Instancia;
            }
        }

        private BancoSistema()
        {
            clientes = new List<Cliente>();
        }

        public void Deposito(double monto, TipoMoneda tipoMoneda, Cuenta cuenta)
        {
            cuenta.Deposito(monto, tipoMoneda);
            cuenta.CantidadDepositos--;
        }

        public void Retiro(double monto, TipoMoneda tipoMoneda, Cuenta cuenta)
        {
            cuenta.Retiro(monto, tipoMoneda);
        }

        public void AgregarCliente(Cliente cliente)
        {
            clientes.Add(cliente);
        }

        public List<Cliente> ListarClientesConCuentas()
        {
            return clientes;
        }

        public List<Cliente> ListarClientesConMasDeDosCuentas()
        {
            List<Cliente> aux = new List<Cliente>();

            foreach (Cliente cliente in clientes)
            {
                if (cliente.Cuentas.Count > 2)
                {
                    aux.Add(cliente);
                }
            }

            return aux;
        }

        public List<Cuenta> ListarCuentasMayorAMil()
        {
            List<Cuenta> aux = new List<Cuenta>();

            foreach (Cliente cliente in clientes)
            {
                foreach (Cuenta cuenta in cliente.Cuentas)
                {
                    double valoresDolares = cuenta.Saldo;

                    if (cuenta.Moneda == TipoMoneda.PESOS)
                    {
                        valoresDolares = cuenta.Saldo / Cuenta.Cambio;
                    }

                    if (valoresDolares > 1000)
                    {
                        aux.Add(cuenta);
                    }

                }
            }

            return aux;
        }

        public List<Cuenta> ListarCuentasMoneda(TipoMoneda moneda)
        {
            List <Cuenta> aux = new List<Cuenta>();

            foreach (Cliente cliente in clientes)
            {
                foreach (Cuenta cuenta in cliente.Cuentas)
                {
                    if(cuenta.Moneda == moneda) aux.Add(cuenta);
                }
            }

            return aux;
        }

        public List<Cuenta> ListarCuentasPesosMas3Depos()
        {
            List<Cuenta> aux = new List<Cuenta>();

            foreach (Cliente cliente in clientes)
            {
                foreach (Cuenta cuenta in cliente.Cuentas)
                {
                    if (cuenta.Moneda == TipoMoneda.PESOS && cuenta.CantidadDepositos >3)
                    {
                        aux.Add(cuenta);
                    }

                }
            }

            return aux;
        }

        public string TotalDineroBanco(TipoMoneda enMoneda)
        {
            double totalDineroBancoPesos = 0;
            double totalDineroBancoDolares = 0;
            double totalDineroBanco;
            string moneda;

            foreach (Cliente cliente in clientes)
            {
                foreach (Cuenta cuenta in cliente.Cuentas)
                {
                    if (cuenta.Moneda == TipoMoneda.PESOS)
                    {
                        totalDineroBancoPesos += cuenta.Saldo;
                    }
                    else
                    {
                        totalDineroBancoDolares += cuenta.Saldo;
                    }

                }
            }

            if (enMoneda == TipoMoneda.DOLARES)
            {
                totalDineroBanco = totalDineroBancoDolares + totalDineroBancoPesos / Cuenta.Cambio;
                moneda = "Dólares";
            }
            else
            {
                totalDineroBanco = totalDineroBancoPesos + totalDineroBancoDolares * Cuenta.Cambio;
                moneda = "Pesos";
            }
            string TotalDinero = totalDineroBanco.ToString();
            return $"El total de dinero del Banco en {moneda} es de {TotalDinero}";




        }
    }
}
