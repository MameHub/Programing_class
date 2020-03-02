using System;

namespace ConditionalStatements2
{
    class Program
    {
        static void Main(string[] args)
        {
            // El usuario introduce un número y comprobamos si es par o inpar.

            Console.Write("Introduce un número: ");
            int x = int.Parse(Console.ReadLine());

            if (x % 2 == 0)
            {
                Console.WriteLine("El número introducido es par.");
            }
            else
            {
                Console.WriteLine("El número introducido es inpar.");
            }
        }
    }
}
