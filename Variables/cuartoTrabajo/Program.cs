using System;

namespace cuartoTrabajo
{
    class Program
    {
        static void Main(string[] args)
        {
            // El usuario introduce dos números y sacar si el número 1 es multiplo del número 2 o no.
            Console.Write("Introduce el primer número: ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("Introduce el segundo número: ");
            int y = int.Parse(Console.ReadLine());

            if (x % y == 0)
            {
                Console.WriteLine("Es múltiplo.");
            }
            else
            {
                Console.WriteLine("No es múltiplo.");
            }
            Console.ReadLine();
        }
    }
}
