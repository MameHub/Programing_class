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

            int op;

            do
            {
                Console.Write("Introduzca el primer número: ");
                x = int.Parse(Console.ReadLine());
                Console.Write("Introduzca el segundo número: ");
                y = int.Parse(Console.ReadLine());
                Console.WriteLine(" Introduzca la operación que desea realizar: \n 1.- Suma. \n 2.- Resta. \n 3.- Multiplicación. \n 4.- División. \n 5.- Salir");
                switch (op = int.Parse(Console.ReadLine()))
                {
                    case 1:
                        Console.WriteLine("El resultado de la suma es: " + (x + y) + ".");
                        break;
                    case 2:
                        Console.WriteLine("El resultado de la resta es: " + (x - y) + ".");
                        break;
                    case 3:
                        Console.WriteLine("El resultado de la multiplicación es: " + (x * y) + ".");
                        break;
                    case 4:
                        Console.WriteLine("El resultado de la división es: " + (x / y) + ".");
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
