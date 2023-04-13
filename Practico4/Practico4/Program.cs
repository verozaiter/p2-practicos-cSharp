using Dominio;

namespace Practico4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cliente clienteUno = new Cliente()
            {
                NombreCompleto = "Romina Perez",
                CI = 1234567
            };

            Cliente clienteDos = new Cliente()
            {
                NombreCompleto = "Federico Zaiter",
                CI = 2344567
            };

            //Asignar cuentas a cliente
            Cuenta cuentaPesos = new Cuenta()
            {
                Numero = 123,
                Saldo = 13000,
                Moneda = TipoMoneda.PESOS
            };

            Cuenta cuentaDolares = new Cuenta()
            {
                Numero = 1235,
                Saldo = 1200,
                Moneda = TipoMoneda.DOLARES
            };

            cuentaDolares.Deposito(200, TipoMoneda.DOLARES);
            cuentaDolares.Deposito(3000, TipoMoneda.PESOS);
            cuentaDolares.Deposito(1000, TipoMoneda.DOLARES);
            cuentaDolares.Deposito(1000, TipoMoneda.DOLARES);

            clienteUno.Cuentas.Add(cuentaPesos);
            clienteDos.Cuentas.Add(cuentaDolares);

            clienteDos.ModificarNombre("FedeRico Zaiter");

            BancoSistema banco = BancoSistema.ObtenerInstancia;
            banco.AgregarCliente(clienteUno);
            banco.AgregarCliente(clienteDos);

            Console.WriteLine();
            //Listar todos los clientes con sus cuentas.
            Console.WriteLine("Listar todos los clientes con sus cuentas.");
            List<Cliente> clientes = banco.ListarClientesConCuentas();
            foreach (Cliente cliente in clientes)
            {
                Console.WriteLine(cliente);
                Console.WriteLine();
            }

            Console.WriteLine();
            //Listar los clientes con más de dos cuentas.
            Console.WriteLine("Listar los clientes con más de dos cuentas.");
            List<Cliente> clientesConMasDe2 = banco.ListarClientesConMasDeDosCuentas();
            foreach (Cliente cliente in clientesConMasDe2)
            {
                Console.WriteLine(cliente);
                Console.WriteLine();
            }

            Console.WriteLine();
            //Listar las cuentas en una moneda especificada.
            Console.WriteLine("Listar las cuentas en una moneda especificada.");
            List<Cuenta> cuentasMoneda = banco.ListarCuentasMoneda(TipoMoneda.PESOS);
            foreach(Cuenta cuenta in cuentasMoneda)
            {
                Console.WriteLine(cuenta);
                Console.WriteLine();
            }

            Console.WriteLine();
            //Listar aquellas cuentas que superen los 1000 u$s o pesos correspondientes.
            Console.WriteLine("Listar aquellas cuentas que superen los 1000 u$s o pesos correspondientes.");
            List<Cuenta> cuentasMasMil = banco.ListarCuentasMayorAMil();
            foreach (Cuenta cuenta in cuentasMasMil)
            {
                Console.WriteLine(cuenta);
                Console.WriteLine();
            }

            Console.WriteLine();
            //Listar las cuentas en pesos que tengan más de 3 depósitos.
            Console.WriteLine("Listar las cuentas en pesos que tengan más de 3 depósitos.");
            List<Cuenta> cuentasMasDe3Depos = banco.ListarCuentasPesosMas3Depos();
            foreach (Cuenta cuenta in cuentasMasDe3Depos)
            {
                Console.WriteLine(cuenta);
                Console.WriteLine();
            }

            Console.WriteLine();
            //Indicar el total de dinero que tiene el banco con las cuentas de todos sus clientes.
            Console.WriteLine("Indicar el total de dinero que tiene el banco con las cuentas de todos sus clientes.");
            string TotalDineroBanco = banco.TotalDineroBanco(TipoMoneda.DOLARES);
            Console.WriteLine(TotalDineroBanco);

            Console.ReadLine();
        }
    }
}