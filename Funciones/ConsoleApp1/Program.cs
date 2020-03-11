using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Vamos a hacer una calculadora, para luego integrarla en una función.
            // Le pediremso al usuario dos números y luego le preguntaremos que opción aritmeética quiere realizar, con un do while y un switch.

            int x;
            int y;
            
            Console.Write("Introduzca que operación desea realizar: ");
            int op = 0;

            do
            {
                Console.Write("Introduzca el primer número: ");
                x = int.Parse(Console.ReadLine());
                Console.Write("Introduzca el segundo número: ");
                y = int.Parse(Console.ReadLine());
                Console.WriteLine(" Introduzca la operación que desea realizar: \n 1.- Suma. \n 2.- Resta. \n 3.- Multiplicación. \n 4.- División. \n 5.- Salir");
                switch (op)
                {
                    case 1:
                        int totalSuma = x + y;
                        Console.WriteLine("El resultado de la suma es: " + totalSuma + ".");
                        break;
                    case 2:
                        int totalResta = x - y;
                        break;
                    case 3:
                        int totalMultiplicacion = x * y;
                        break;
                    case 4:
                        int totalDivision = x / y;
                        break;
                    case 5:
                        Console.WriteLine("Hasta luego.");
                        break;
                    default:
                        Console.WriteLine("Esa opción no está disponible..");
                        break;
                }
            } while (op != 5);
        }
    }
}
