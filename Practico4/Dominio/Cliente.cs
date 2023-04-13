namespace Dominio
{
    public class Cliente
    {
        public int CI { get; set; }
        public string NombreCompleto { get; set; }   

        public List<Cuenta> Cuentas { get; set; }

        public Cliente()
        {
            this.Cuentas = new List<Cuenta>();
        }



        public void AgregarCuenta(Cuenta cuenta)
        {
            Cuentas.Add(cuenta);
        }


        //Poder modificar el nombre del cliente.
        public void ModificarNombre(string nuevoNombre)
        {
            this.NombreCompleto = nuevoNombre;
        }
        
        public override string ToString()
        {
            string retorno = $"Nombre: {NombreCompleto}\nCédula de identidad: {CI}\nCuentas: ";
           
            if (Cuentas.Count == 0)
            {
                retorno = retorno + "El usuario no tiene cuentas.";
            }
            foreach (Cuenta cuenta in Cuentas)
            {
                retorno += "\n" + cuenta;
            }
            return retorno;
        }
    }
}