using System.Globalization;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Clase2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool probar = true;
            while (probar)
            {
                Console.WriteLine("Ingrese el número de ejercicio que quiera probar. Ingrese 0 para salir.");
                Console.WriteLine("");
                Console.WriteLine("1 - Ejercicio 1 - Comparación con número de referencia.");
                Console.WriteLine("2 - Ejercicio 2 - Tabla de múltiplos.");
                Console.WriteLine("3 - Ejercicio 3 - Pares comprendidos entre dos valores.");
                Console.WriteLine("4 - Ejercicio 4 - Comparación entre dos números y un valor.");
                Console.WriteLine("5 - Ejercicio 5 - Suma de valores.");
                Console.WriteLine("6 - Ejercicio 6 - Suma cantidad de vocales.");
                Console.WriteLine("7 - Ejercicio 7 - Inversión de palabra.");
                Console.WriteLine("8 - Ejercicio 8 - Indica si la es palíndromo.");
                Console.WriteLine("9 - Ejercicio Extra - Comparación cantidad de consonantes de dos palabras.");
                Console.WriteLine("");

                int numEjercicio;
                bool sePuede = int.TryParse(s: Console.ReadLine(), out numEjercicio);

                if(!sePuede)
                {
                    Console.WriteLine("Por favor ingrese un número.");
                } else
                {
                    switch (numEjercicio)
                    {
                        case 0:
                            probar = false;
                            break;
                        case 1:
                            Console.Clear();
                            Ejercicio1();
                            Console.WriteLine("");
                            break;
                        case 2:
                            Console.Clear();
                            Ejercicio2();
                            Console.WriteLine("");
                            break;
                        case 3:
                            Console.Clear();
                            Ejercicio3();
                            Console.WriteLine("");
                            break;
                        case 4:
                            Console.Clear();
                            Ejercicio4();
                            Console.WriteLine("");
                            break;
                        case 5:
                            Console.Clear();
                            Ejercicio5();
                            Console.WriteLine("");
                            break;
                        case 6:
                            Console.Clear();
                            Ejercicio6();
                            Console.WriteLine("");
                            break;
                        case 7:
                            Console.Clear();
                            Ejercicio7();
                            Console.WriteLine("");
                            break;
                        case 8:
                            Console.Clear();
                            Ejercicio8();
                            Console.WriteLine("");
                            break;
                        case 9:
                            Console.Clear();
                            EjercicioExtra1();
                            Console.WriteLine("");
                            break;
                        default:
                            Console.Clear();
                            Console.WriteLine("Debe elegir del 1 al 9.");
                            Console.WriteLine("");
                            break;
                    }
                }
                
            }
             
        }

        static void Ejercicio1()
        {
            bool salir = false;
            int numeroAComparar = 7;

            while (!salir)
            {
                Console.WriteLine("");
                Console.WriteLine("Ingrese un número. Éste se comparará con un número de referencia. Para salir, ingrese 0.");
                int numero;
                bool sePuede = int.TryParse(s: Console.ReadLine(), out numero);

                if (sePuede)
                {
                    if (numero == 0)
                    {
                        salir = true;
                        Console.WriteLine("");
                    }
                    else if (numero == numeroAComparar)
                    {
                        Console.WriteLine("Los números son iguales. Número de referencia " + numeroAComparar + ".");
                    }
                    else
                    {
                        Console.WriteLine("Los números no son iguales, probá con otro.");
                    }
                }
                else
                {
                    Console.WriteLine("Por favor escriba un número.");
                }
                
            }

        }

        static void Ejercicio4()
        {
            Console.WriteLine("Escriba dos números y un valor distintos.");
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int valor = int.Parse(Console.ReadLine());

            if (num1 < valor && valor < num2 || num1 > valor && valor > num2)
            {
                Console.WriteLine("El valor está comprendido entre los números");
            }
            else
            {
                Console.WriteLine("El valor no está comprendido entre los números");
            }

        }
        static void Ejercicio2()
        {
            bool seguir = true;

            while (seguir)
            {
                Console.WriteLine("Ingrese un número del cual desee ver su tabla de múltiplos.");
                Console.WriteLine("Para salir ingrese 0.");
                int multiplo;
                bool sePuede = int.TryParse(s: Console.ReadLine(), out multiplo);
                
                Console.WriteLine("");

                if (sePuede)
                {
                    if (multiplo == 0)
                    {
                        seguir = false;
                    }
                    else
                    {
                        for (int i = 1; i < 10; i++)
                        {
                            int resultado = multiplo * i;
                            Console.WriteLine(multiplo + " x " + i + " = " + resultado);
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Por favor escriba un número.");
                }

                

                Console.WriteLine("");
            }
        }
        static void Ejercicio3()
        {
            bool seguir = true;

            while (seguir)
            {
                Console.WriteLine("Ingrese dos números. Se mostrarán los números pares comprendidos entre éstos.");
                Console.WriteLine("Para salir ingrese 0.");
                int num1 = int.Parse(Console.ReadLine());

                if (num1 == 0)
                {
                    seguir = false;
                }
                else
                {
                    int num2 = int.Parse(Console.ReadLine());
                    Console.WriteLine("");

                    if (num1 < num2)
                    {
                        for(int i = num1; i < num2 ; i++)
                        {
                            if(i % 2 == 0)
                            {
                                Console.WriteLine(i);
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("El primer número debe ser menor al segundo.");
                    }
                    
                }
                Console.WriteLine("");
            }
        }

        static void Ejercicio5()
        {
            bool seguir = true;
            Console.WriteLine("Ingrese números. Éstos se irán sumando hasta que ingrese 0.");
            Console.WriteLine("");
            int resultado = 0;

            while (seguir)
            {
                int num = int.Parse(Console.ReadLine());

                if (num == 0)
                {
                    seguir = false;
                    Console.WriteLine("");
                } else
                {
                    resultado += num;
                }

            }

            Console.WriteLine("El resultado es: " + resultado);
        }

        static void Ejercicio6()
        {
            Console.WriteLine("Ingrese una palabra. Se mostrará la cantidad de vocales que contiene.");
      
            string palabra = Console.ReadLine();
            string palabraMin = palabra.ToLower();
            int cantVocales = ContarVocales(palabraMin);

            Console.WriteLine("");
            Console.WriteLine("Esta palabra contiene " + cantVocales + " vocales." );
        }

        static void Ejercicio7()
        {
            Console.WriteLine("Ingrese una palabra y se mostrará en el otro sentido.");
            Console.WriteLine("");
            string palabra = Console.ReadLine();
            string palabraInvertida = InvertirPalabra(palabra);
            Console.WriteLine("");

            Console.WriteLine(palabraInvertida);

        }

        static void Ejercicio8()
        {
            Console.WriteLine("Ingrese una palabra y se indicará si la palabra es palíndromo.");
            Console.WriteLine("");
            string palabra = Console.ReadLine();
            string palMinuscula = palabra.ToLower();
            string palabraInvertida = InvertirPalabra(palMinuscula);
            Console.WriteLine("");

            if (palMinuscula == palabraInvertida)
            {
                Console.WriteLine("La palabra es palíndromo.");
            } else 
            {
                Console.WriteLine("La palabra´no es palíndromo.");
            }

        }

        static void EjercicioExtra1()
        {
            Console.WriteLine("Escriba dos palabras. Compararemos la cantidad de consonantes de cada una.");
            Console.WriteLine("");
            string palabra1 = Console.ReadLine();
            string pal1Minuscula = palabra1.ToLower();
            string palabra2 = Console.ReadLine();
            string pal2Minuscula = palabra2.ToLower();
            int cantConsPal1 = ContarConsonantes(pal1Minuscula);
            int cantConsPal2 = ContarConsonantes(pal2Minuscula);
            Console.WriteLine("");

            if (cantConsPal1 > cantConsPal2)
            {
                Console.WriteLine("La primera palabra tiene más consonantes que la segunda.");
            } else if (cantConsPal1 < cantConsPal2) 
            {
                Console.WriteLine("La segunda palabra tiene más consonantes que la primera.");
            }
            else
            {
                Console.WriteLine("La primera palabra tiene la misma cantidad de consonantes que la segunda.");
            }

        }

        static int ContarConsonantes(string palabra)
        {
            int cantConsonantes = 0;

            foreach (char letra in palabra)
            {
                int a = (int)letra;

                if (a > 97 && a < 101 || a > 101 && a < 105 || a > 105 && a < 111 || a > 111 && a < 117 || a > 117 && a < 123)
                {
                    cantConsonantes++;
                }
            }

            return cantConsonantes;
        }

        static int ContarVocales(string palabra) {
            int cantVocales = 0;

            foreach (char letra in palabra)
            {
                if (letra == 'a' || letra == 'e' || letra == 'i' || letra == 'o' || letra == 'u')
                {
                    cantVocales++;
                }
            }

            return cantVocales;
        }

        static string InvertirPalabra(string palabra)
        {
            string palabraInvertida = "";

            for (int i = palabra.Length - 1; i >= 0; i--)
            {
                palabraInvertida += palabra[i];
            }

           
            return palabraInvertida;
        }
    }
}