using System;
using System.Collections.Generic;

namespace Arrays
{
    class Program
    {
        static int PreguntarNumero(string texto)
        {
            Console.Write(texto);
            return int.Parse(Console.ReadLine());
        }

        static int Suma(int x, int y)
        {
            return x + y;
        }

        static int Resta(int x, int y)
        {
            return x - y;
        }

        static int Multiplicacion(int x, int y)
        {
            return x * y;
        }

        static int Division(int x, int y)
        {
            return x / y;
        }

        static void PintarOpciones()
        {
            Console.WriteLine("1. Suma");
            Console.WriteLine("2. Resta");
            Console.WriteLine("3. Multiplicación");
            Console.WriteLine("4. División");
            Console.WriteLine("5. Salir");
        }

        static void Main(string[] args)
        {
            int option = 0;
            do
            {
                int num1 = PreguntarNumero("Introduzca un número: ");
                int num2 = PreguntarNumero("Introduzca un número: ");
                Console.WriteLine();
                PintarOpciones();
                option = PreguntarNumero("Introduce una opción: ");
                switch (option)
                {
                    case 1:
                        Console.WriteLine("Suma: " + Suma(num1, num2));
                        break;
                    case 2:
                        Console.WriteLine("Resta: " + Resta(num1, num2));
                        break;
                    case 3:
                        Console.WriteLine("Multiplicación: " + Multiplicacion(num1, num2));
                        break;
                    case 4:
                        Console.WriteLine("División: " + Division(num1, num2));
                        break;
                    case 5:
                        Console.WriteLine("¡Hasta luego!");
                        break;
                    default:
                        Console.WriteLine("Error, opción incorrecta.");
                        break;
                }

            } while (option != 5);
        }
    }
}
