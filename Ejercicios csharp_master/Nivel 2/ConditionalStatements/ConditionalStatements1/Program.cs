using System;

namespace ConditionalStatements1
{
    class Program
    {
        static void Main(string[] args)
        {
            // El usuario introduce dos números y comprobamos si son iguales o no.

            Console.Write("Introduce el primer número: ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("Introduce el segundo número: ");
            int y = int.Parse(Console.ReadLine());

            if (x == y)
            {
                Console.WriteLine("Los números introducidos son iguales.");
            }
            else
            {
                Console.WriteLine("Los números introducidos no son iguales.");
            }
        }
    }
}
