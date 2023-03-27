namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ejercicio1();
            Ejercicio2();
            Ejercicio3();
        }

        static void Ejercicio1()
        {
            Banda cuartetoDeNos = new Banda(1, "Cuarteto De Nos", "Rock");
            Banda onceTiros = new Banda(2, "Once Tiros", "Rock");

            Espectaculo teatroDeVerano = new Espectaculo(new DateTime(2020, 02, 02), "Fiesta del Rock", "Full Rock", "Elisa Fernandez", cuartetoDeNos);

            Console.WriteLine(onceTiros.HaEstadoEn(teatroDeVerano) ? "Sí" : "No");
        }

        static void Ejercicio2()
        {
            Chofer Mario = new Chofer(123, "Mario Gomez", new DateTime(2019, 6, 5));
            Remise RemiseUno = new Remise("SCP1234", "Citroen", "C3", 254163);

            Viaje viaje1 = new Viaje()
            {
                Fecha = new DateTime(2023, 03, 25),
                CiudadOrigen = "Montevideo",
                CiudadDestino = "Ciudad De La Costa",
                Chofer = Mario,
                Remise = RemiseUno,

            };

            
        }

        static void Ejercicio3()
        {
            Socio socio1 = new Socio() { Nombre = "pepe", Apellido = "Suarez", FechaNac = new DateTime(1996, 3, 18)};

           
            if (socio1.EsMayor())
            {
                Console.WriteLine("El socio es mayor de edad.");
            }
        }
    }
}